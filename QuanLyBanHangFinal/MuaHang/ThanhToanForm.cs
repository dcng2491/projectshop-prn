using Microsoft.Extensions.Configuration;
using QuanLyBanHangFinal.Model;
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

namespace QuanLyBanHangFinal.MuaHang
{
    public partial class ThanhToanForm : Form
    {
        private int mskh;
        private string tenkh;
        MUAHANG muahang = new MUAHANG();
        bool check = true;
        private int soluong;
        String tensp;

        public ThanhToanForm()
        {
            InitializeComponent();
        }
        public ThanhToanForm(int mskh, string tenkh)
        {
            InitializeComponent();
            this.mskh = mskh;
            this.tenkh = tenkh;
        }

        private void ThanhToanForm_Load(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("SELECT tenhang as'Tên mặt hàng',soluong as 'Số lượng',gia as 'Giá' FROM XUATHOADON WHERE thanhtoan=0 AND mskh =" + mskh);
            dataGridViewTT.DataSource = muahang.layHangHoa(command);
            labelMaKH.Text = "Mã khách hàng: " + mskh;
            soluong = Convert.ToInt32(dataGridViewTT.CurrentRow.Cells[2].ToString());
            tensp = dataGridViewTT.CurrentRow.Cells[1].ToString();
            labelTenKH.Text = "Khách hàng: " + tenkh;
            double value = Convert.ToDouble(muahang.tongtien(mskh));
            labelTongTien.Text = "Tổng tiền: " + string.Format(new CultureInfo("vi-VN"), "{0:#,##0.00}", value) + " VND";
            dataGridViewTT.ReadOnly = true;
            StyleDatagridview();

        }
        void StyleDatagridview()
        {
            dataGridViewTT.ReadOnly = true;
            dataGridViewTT.RowTemplate.Height = 20;
            dataGridViewTT.BorderStyle = BorderStyle.None;
            dataGridViewTT.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewTT.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewTT.EnableHeadersVisualStyles = false;
            dataGridViewTT.AllowUserToAddRows = false;
            dataGridViewTT.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewTT.ColumnHeadersDefaultCellStyle.Font = new Font("Times New Roman", 12);

            //dòng tiêu đề của bảng
            //căn giữa 
            dataGridViewTT.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;


        }
        private void buttonXuatHD_Click(object sender, EventArgs e)
        {

        }

        public string getConnect()
        {
            string connectionString;

            var conf = new ConfigurationBuilder()
              .SetBasePath(Directory.GetCurrentDirectory())

              //             need full path
              .AddJsonFile("appsettings.json", true, true)

              .Build();
            connectionString = conf.GetConnectionString("DbConnection");


            return connectionString;

        }


        private void buttonThanhToan_Click(object sender, EventArgs e)
        {
            if (check == true)
            {
                string connectionString = getConnect();
                SqlConnection connection = new SqlConnection(connectionString);
                HOADON hoadon = new HOADON();
                
                int magiohang = -1;
                SqlCommand command = new SqlCommand("SELECT * FROM GIOHANG WHERE mskh=" + mskh, connection);
                connection.Open();
                 SqlDataReader reader = command.ExecuteReader();
                reader.Read();
                if (reader.HasRows)
                {
                    magiohang = Convert.ToInt32(reader["magiohang"]);
                }
                reader.Close();
                connection.Close();

                DateTime ngaymua = DateTime.Now;
                double tongtien = Convert.ToDouble(muahang.tongtien(mskh));
                if (hoadon.kthoadon(GLOBALS.GlobalUserId) == false)
                {
                    MessageBox.Show("Giỏ hàng đã có hóa đơn vui lòng kiểm tra tại quầy", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    if (hoadon.themvaohoadon(mskh, magiohang, tongtien, ngaymua))
                    {
                        check = false;
                        MATHANG mh = new MATHANG();
                        if (mh.update2(tensp, soluong))
                        {
                            MessageBox.Show("update success");
                        }
                        MessageBox.Show("Kiểm tra tại quầy", "Thanh toán", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        

                    }
                    else
                    {
                        MessageBox.Show("Lỗi", "Thanh toán", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Đã xác nhận vui lòng không xác nhận lại", "Thanh toán", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

       

        private void buttonThanhToan_Click_1(object sender, EventArgs e)
        {
            if (check == true)
            {
                string connectionString = getConnect();
                SqlConnection connection = new SqlConnection(connectionString);
                HOADON hoadon = new HOADON();
                
                int magiohang = -1;
                SqlCommand command = new SqlCommand("SELECT * FROM GIOHANG WHERE mskh=" + mskh, connection);
                connection.Open();
                 SqlDataReader reader = command.ExecuteReader();
                reader.Read();
                if (reader.HasRows)
                {
                    magiohang = Convert.ToInt32(reader["magiohang"]);
                }
                reader.Close();
                connection.Close(); 

                DateTime ngaymua = DateTime.Now;
                double tongtien = Convert.ToDouble(muahang.tongtien(mskh));
                if (hoadon.kthoadon(GLOBALS.GlobalUserId) == false)
                {
                    MessageBox.Show("Giỏ hàng đã có hóa đơn vui lòng kiểm tra tại quầy", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    this.Close();
                }
                else
                {
                    if (hoadon.themvaohoadon(mskh, magiohang, tongtien, ngaymua))
                    {
                        check = false;
                        MessageBox.Show("Kiểm tra tại quầy", "Thanh toán", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Lỗi", "Thanh toán", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Đã xác nhận vui lòng không xác nhận lại", "Thanh toán", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void ThanhToanForm_Load_1(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("SELECT tenhang as'Tên mặt hàng',soluong as 'Số lượng',gia as 'Giá' FROM XUATHOADON WHERE thanhtoan=0 AND mskh =" + mskh);
            dataGridViewTT.DataSource = muahang.layHangHoa(command);
            labelMaKH.Text = "Mã khách hàng: " + mskh;
            labelTenKH.Text = "Khách hàng: " + tenkh;
            double value = Convert.ToDouble(muahang.tongtien(mskh));
            labelTongTien.Text = "Tổng tiền: " + string.Format(new CultureInfo("vi-VN"), "{0:#,##0.00}", value) + " VND";
            dataGridViewTT.ReadOnly = true;
            StyleDatagridview();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
