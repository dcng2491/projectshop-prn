using Microsoft.Extensions.Configuration;
using QuanLyBanHangFinal.Model;
using QuanLyBanHangFinal.MuaHang;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBanHangFinal.NhanVien
{
    public partial class HoaDonForm : UserControl
    {
        string tenNV;
        THANHTOAN thanhtoan = new THANHTOAN();
        DOANHTHU dt = new DOANHTHU();
        HOADON hoadon = new HOADON();
        public HoaDonForm()
        {
            InitializeComponent();
        }

        public string getConnect()
        { string connectionString;
               
            var conf = new ConfigurationBuilder()
              .SetBasePath(Directory.GetCurrentDirectory())

              //             need full path
              .AddJsonFile("appsettings.json", true, true)

              .Build();
            connectionString = conf.GetConnectionString("DbConnection");


            return connectionString;

        }
        bool verif()
        {
            if ((textBoxMaHD.Text.Trim() == "") || (textBoxMaNV.Text.Trim() == "") || (textBoxTenNV.Text.Trim() == "") || (textBoxTongTien.Text.Trim() == ""))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        void StyleDatagridview()
        {
            textBoxMaNV.ReadOnly = true;
            textBoxMaNV.Enabled = false;
          
            textBoxTenNV.ReadOnly = true;
            textBoxTenNV.Enabled = false;
         
            dataGridViewHoaDon.ReadOnly = true;
            dataGridViewHoaDon.RowTemplate.Height = 60;
            dataGridViewHoaDon.BorderStyle = BorderStyle.None;

            dataGridViewHoaDon.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
        
         
            dataGridViewHoaDon.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewHoaDon.EnableHeadersVisualStyles = false;
            dataGridViewHoaDon.AllowUserToAddRows = false;
            dataGridViewHoaDon.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
    

            //dòng tiêu đề của bảng

            //căn giữa 


        }
        void refresh()
        {
            MUAHANG mh = new MUAHANG();
            SqlCommand command = new SqlCommand("SELECT mahoadon as 'Hóa đơn',mskh as 'Mã khách hàng',magiohang as 'Giỏ hàng',tongtien as 'Tổng tiền',ngaymua as 'Ngày mua' FROM HOADON where trangthai=0");
            dataGridViewHoaDon.DataSource = mh.layHangHoa(command);
            getImageAndUsername();
            StyleDatagridview();
        }
        public void getImageAndUsername()
        {
            string connectionString = getConnect();
            SqlConnection connection = new SqlConnection(connectionString);
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            SqlCommand command = new SqlCommand("SELECT * FROM NHANVIEN WHERE msnv=@id", connection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = GLOBALS.GlobalUserId;
            adapter.SelectCommand = command;
            adapter.Fill(table);
            if (table.Rows.Count > 0)
            {
                byte[] pic = (byte[])table.Rows[0]["hinh"];
                MemoryStream picture = new MemoryStream(pic);
                pictureBoxNhanVien.Image = Image.FromStream(picture);
                labelNhanVien.Text = "Nhân viên: " + table.Rows[0]["hoten"].ToString();
                tenNV = table.Rows[0]["hoten"].ToString();
            }
        }
        private void buttonThanhToan_Click(object sender, EventArgs e)
        {
            int mahoadon = Convert.ToInt32(textBoxMaHD.Text);
            int msnv = Convert.ToInt32(textBoxMaNV.Text);
            int mskh = Convert.ToInt32(textBoxMaKH.Text);
            DateTime ngaythanhtoan = dateTimePickerNgayThanhToan.Value;
            double tongtien = Convert.ToDouble(textBoxTongTien.Text);
            int magiohang = Convert.ToInt32(dataGridViewHoaDon.CurrentRow.Cells[2].Value.ToString());
            if (verif() == false)
            {
                MessageBox.Show("Nhập thông tin", "LỖI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                decimal check;
                if (decimal.TryParse(textBoxMaHD.Text, out check) == false)
                {
                    MessageBox.Show("nhập đúng định dạng mã số nhân viên", "LỖI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    if (thanhtoan.thanhtoan(mahoadon, msnv, ngaythanhtoan, tongtien))
                    {
                        dt.addDoanhthu(tongtien, ngaythanhtoan);
                        MessageBox.Show("Thanh Toán thành công", "Thanh toán", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        thanhtoan.updatetrangthai(mahoadon, mskh); //sửa hóa đơn lại thành đã thanh toán 1
                        //cập nhật trạng thái là thanh toán r thì mới được xóa
                        thanhtoan.trangthaithanhtoan(magiohang, mskh);
                        //làm 1 khúc inser vào lịch sử thủ công
                        lichsumuahang(magiohang, mskh);
                        thanhtoan.xoahethangtronggio(magiohang, mskh); //xóa hàng đã thanh toán
                        refresh();
                        refresh2();
                    }
                    else
                    {
                        MessageBox.Show("Lỗi", "Thanh toán", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
        void lichsumuahang(int magiohang, int mskh)
        {
            MUAHANG mh = new MUAHANG();
            string connectionString = getConnect();
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand("SELECT * FROM GIOHANG WHERE mskh=@mskh AND magiohang=@mgh AND thanhtoan=1", connection);
            connection.Open();
            command.Parameters.Add("@mskh", SqlDbType.Int).Value = mskh;
            command.Parameters.Add("@mgh", SqlDbType.Int).Value = magiohang;
            //adapter.SelectCommand = command;
            int mahang;
            string tenhang;
            int soluong;
            double gia;
            DateTime ngay = DateTime.Now;

            SqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    mahang = Convert.ToInt32(reader["mahang"].ToString());
                    tenhang = reader["tenhang"].ToString();
                    soluong = Convert.ToInt32(reader["soluong"].ToString());
                    gia = Convert.ToDouble(reader["gia"].ToString());
                    //mh.lichsugiohang(magiohang, mahang, tenhang, soluong, gia, mskh, ngay);
                }
            }
            reader.Close();
            //count = (Int32)command.ExecuteScalar();
            connection.Close();
        }
        void refresh2()
        {
            textBoxMaHD.Text = "";
            textBoxMaKH.Text = "";
            textBoxMaNV.Text = "";
            textBoxTenNV.Text = "";
            textBoxTongTien.Text = "";
        }
        private void buttonKiGui_Click(object sender, EventArgs e)
        {
            if (verif() == false)
            {
                MessageBox.Show("Nhập thông tin", "LỖI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                decimal check;
                if (decimal.TryParse(textBoxMaHD.Text, out check) == false)
                {
                    MessageBox.Show("nhập đúng định dạng mã số nhân viên", "LỖI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    int mahoadon = Convert.ToInt32(textBoxMaHD.Text);
                    int mskh = Convert.ToInt32(textBoxMaKH.Text);
                    DialogResult result = MessageBox.Show("Bạn có muốn kí gửi hóa đơn này không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        if (thanhtoan.kiguihoadon(mahoadon, mskh))
                        {
                            MessageBox.Show("Đã kí gửi hóa đơn", "Thanh toán", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            //sửa hóa đơn lại thành đã thanh toán
                            refresh();
                        }
                        else
                        {
                            MessageBox.Show("Lỗi", "Thanh toán", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }

                }
            }
        }

        private void buttonHuyDon_Click(object sender, EventArgs e)
        {
            if (textBoxMaHD.Text.Trim() == "" || textBoxMaKH.Text.Trim() == "" || dataGridViewHoaDon.CurrentRow.Cells[2].Value == null)
            {
                MessageBox.Show("Vui lòng nhập thông tin mã hóa đơn và mã số khách hàng", "Hủy hóa đơn", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                decimal check;
                if (decimal.TryParse(textBoxMaHD.Text, out check) == false || decimal.TryParse(textBoxMaHD.Text, out check) == false)
                {
                    MessageBox.Show("Nhập đúng định dạng Mã hóa đơn/MSKH", "LỖI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    try
                    {
                        int mahoadon = Convert.ToInt32(textBoxMaHD.Text);
                        int mskh = Convert.ToInt32(textBoxMaKH.Text);
                        int magiohang = Convert.ToInt32(dataGridViewHoaDon.CurrentRow.Cells[2].Value.ToString());

                        DialogResult result = MessageBox.Show("Bạn có muốn hủy hóa đơn này không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (result == DialogResult.Yes)
                        {
                            if (hoadon.HuyHoaDon(mahoadon, mskh) == true)
                            {

                                MessageBox.Show("Hủy hóa đơn thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                //xóa trong don huy
                                refresh();
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }


                }
            }
        }

        private void buttonMokigui_Click(object sender, EventArgs e)
        {
            KiGuiForm kigui = new KiGuiForm();
            kigui.ShowDialog();
            refresh();
        }

        private void HoaDonForm_Load(object sender, EventArgs e)
        {
            MUAHANG mh = new MUAHANG();
            SqlCommand command = new SqlCommand("SELECT mahoadon as 'Hóa đơn',mskh as 'Mã khách hàng',magiohang as 'Giỏ hàng',tongtien as 'Tổng tiền',ngaymua as 'Ngày mua' FROM HOADON where trangthai=0");
            dataGridViewHoaDon.DataSource = mh.layHangHoa(command);
            getImageAndUsername();
            StyleDatagridview();
        }

        private void dataGridViewHoaDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBoxMaHD.Text = dataGridViewHoaDon.CurrentRow.Cells[0].Value.ToString();
            textBoxMaKH.Text = dataGridViewHoaDon.CurrentRow.Cells[1].Value.ToString();
            textBoxMaNV.Text = GLOBALS.GlobalUserId.ToString();
            textBoxTenNV.Text = tenNV;
            textBoxTongTien.Text = dataGridViewHoaDon.CurrentRow.Cells[3].Value.ToString();
            double value = Convert.ToDouble(textBoxTongTien.Text);
            textBoxTongTien.Text = string.Format(new CultureInfo("vi-VN"), "{0:#,##0.00}", value);
        }

        private void dataGridViewHoaDon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
