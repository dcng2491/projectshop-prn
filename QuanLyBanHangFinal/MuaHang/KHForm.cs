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
    public partial class KHForm : Form
    {
        MUAHANG muahang = new MUAHANG();
        
        string tenkh;
        private int magh;
        bool check = true;
        double coupon = 1;
        bool check2 = false;


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


        public KHForm()
        {
            InitializeComponent();
        }
        public KHForm(int magh)
        {
            InitializeComponent();
            this.magh = magh;
        }
        private void buttonThem_Click(object sender, EventArgs e)
        {
            if (magh == 0)
            {
                MessageBox.Show("Vui lòng chọn giỏ hàng để mua sắm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {

                if (checkrong() == false)
                {
                    MessageBox.Show("Vui lòng điền đầy đủ thông mặt hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    try
                    {
                        int mskh = GLOBALS.GlobalUserId;
                        string tenhang = textBoxTenHang.Text;
                        int mahang = Convert.ToInt32(textBoxMaHang.Text);
                        int magiohang = magh;
                        double gia = Convert.ToDouble(textBoxGia.Text);
                        int soluong = Convert.ToInt32(numericSoLuong.Text);
                        double tonggia = gia * soluong;
                        if (check2 == true) //áp dụng mã giảm giá
                        {
                            tonggia = tonggia - tonggia * coupon;
                        }
                        if (muahang.themhangvaogio(magiohang, mahang, tenhang, soluong, tonggia, mskh))
                        {
                            //muahang.lichsugiohang(magiohang, mahang, tenhang, soluong, tonggia, mskh);
                            MessageBox.Show("Thêm thành công", "Hàng hóa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            giohang();
                            refresh();
                            refresh2();
                        }
                        else
                        {
                            MessageBox.Show("Lỗi", "Hàng hóa", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Vui lòng kiểm tra lại thông tin nhập", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
                bool checkrong()
                {
                    if (textBoxGia.Text.Trim() == "" || textBoxMaHang.Text.Trim() == "" || pictureBoxHinh.Image == null)
                    {
                        return false;
                    }
                    else
                        return true;
                }
            }
        }

        private void dataGridViewMatHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBoxMaHang.Text = dataGridViewMatHang.CurrentRow.Cells[0].Value.ToString();
            textBoxTenHang.Text = dataGridViewMatHang.CurrentRow.Cells[2].Value.ToString();
            textBoxGia.Text = dataGridViewMatHang.CurrentRow.Cells[4].Value.ToString();
            byte[] pic;
            pic = (byte[])dataGridViewMatHang.CurrentRow.Cells[3].Value;
            MemoryStream picture = new MemoryStream(pic);
            pictureBoxHinh.Image = Image.FromStream(picture);
            double value = Convert.ToDouble(textBoxGia.Text);
            textBoxGia.Text = string.Format(new CultureInfo("vi-VN"), "{0:#,##0}", value);
        }

        void refresh()
        {
            textBoxMaHang.Text = "";
            textBoxTenHang.Text = "";
            textBoxGia.Text = "";
            pictureBoxHinh.Image = null;
            numericSoLuong.Value = 0;
        }


        public void giohang()
        {
            string connectionString = getConnect();

            SqlConnection connection = new SqlConnection(connectionString);
            int count = 0;
            SqlCommand command2 = new SqlCommand("SELECT * FROM dbo.GIOHANG WHERE mskh=" + GLOBALS.GlobalUserId + "AND thanhtoan=0", connection);
            connection.Open();
            SqlDataReader reader = command2.ExecuteReader();
            if (reader.HasRows)
            {
                //reader.Read();
                while (reader.Read())
                {
                    magh = Convert.ToInt32(reader["magiohang"].ToString());
                    count++;
                }
                check = false;
            }
            reader.Close();
            //count = (Int32)command.ExecuteScalar();
            connection.Close();
            if (count > 0)
            {

                
            }
        }
        void StyleDatagridview()
        {
            textBoxGia.ReadOnly = true;
            textBoxGia.Enabled = false;
          
            textBoxMaHang.ReadOnly = true;
            textBoxMaHang.Enabled = false;
        
            textBoxTenHang.ReadOnly = true;
            textBoxTenHang.Enabled = false;
         
            dataGridViewMatHang.ReadOnly = true;
            dataGridViewMatHang.BorderStyle = BorderStyle.None;
       
            dataGridViewMatHang.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
  
       
            dataGridViewMatHang.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewMatHang.EnableHeadersVisualStyles = false;
            dataGridViewMatHang.AllowUserToAddRows = false;
            dataGridViewMatHang.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
     

            //dòng tiêu đề của bảng
          
            //căn giữa 


        }
        public void getImageAndUsername()
        {
            string connectionString = getConnect();

            SqlConnection connection = new SqlConnection(connectionString);
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            SqlCommand command = new SqlCommand("SELECT * FROM KHACHHANG WHERE mskh=@id", connection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = GLOBALS.GlobalUserId;
            adapter.SelectCommand = command;
            adapter.Fill(table);
            if (table.Rows.Count > 0)
            {
                tenkh = table.Rows[0]["hoten"].ToString();
                labelKH.Text = "Khách hàng: " + table.Rows[0]["hoten"].ToString();

            }
        }
        private void KHForm_Load(object sender, EventArgs e)
        {
            textBoxGia.ReadOnly = true;
            textBoxGia.Enabled = false;
            textBoxGia.BackColor = Color.FromArgb(122, 122, 122);
            SqlCommand command = new SqlCommand("SELECT mahang as 'Mã mặt hàng',loaihang as 'Loại hàng',tenhang as 'Tên mặt hàng',hinh as 'Hình',gia as'Giá',soluong as 'Số lượng' FROM HANGHOA");
            dataGridViewMatHang.DataSource = muahang.layHangHoa(command);
            DataGridViewImageColumn picCol = new DataGridViewImageColumn();
            picCol = (DataGridViewImageColumn)dataGridViewMatHang.Columns[3];
            picCol.ImageLayout = DataGridViewImageCellLayout.Stretch;

            getImageAndUsername();
            //check giỏ hàng
            giohang();
            //hien thi gio hang
        

            StyleDatagridview();
        }
        void refresh2()
        {
        
            SqlCommand command = new SqlCommand("SELECT mahang as 'Mã mặt hàng',loaihang as 'Loại hàng',tenhang as 'Tên mặt hàng',hinh as 'Hình',gia as'Giá',soluong as 'Số lượng' FROM HANGHOA");
            dataGridViewMatHang.DataSource = muahang.layHangHoa(command);
            DataGridViewImageColumn picCol = new DataGridViewImageColumn();
            picCol = (DataGridViewImageColumn)dataGridViewMatHang.Columns[3];
            picCol.ImageLayout = DataGridViewImageCellLayout.Stretch;
            StyleDatagridview();
        }
        private void pictureBoxGioHang_Click(object sender, EventArgs e)
        {

            int mskh = GLOBALS.GlobalUserId;
            GioHangForm giohang = new GioHangForm(mskh, tenkh);
            giohang.ShowDialog();
            refresh2();
        }

        private void buttonThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonDangXuat_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 lo = new Form1();
            lo.ShowDialog();
        }

        private void buttonChonGH_Click(object sender, EventArgs e)
        {


            if (check == false)
            {
                MessageBox.Show("Khách hàng đang có giỏ hàng", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                this.Hide();
                ChonGioHang chongh = new ChonGioHang();
                chongh.ShowDialog();
                this.Close();
            }

        }

        private void labelGioHang_Click(object sender, EventArgs e)
        {

        }

        private void customButton1_Click(object sender, EventArgs e)
        {
            
        }
        Random random = new Random();
        int x = 158, y = 69, a = 1;

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 lo = new Form1();
            lo.ShowDialog();





        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void KHForm_Load_1(object sender, EventArgs e)
        {

            textBoxGia.ReadOnly = true;
            textBoxGia.Enabled = false;
            textBoxGia.BackColor = Color.FromArgb(122, 122, 122);
            SqlCommand command = new SqlCommand("SELECT mahang as 'Mã mặt hàng',loaihang as 'Loại hàng',tenhang as 'Tên mặt hàng',hinh as 'Hình',gia as'Giá',soluong as 'Số lượng' FROM HANGHOA");
            dataGridViewMatHang.DataSource = muahang.layHangHoa(command);
            DataGridViewImageColumn picCol = new DataGridViewImageColumn();
            picCol = (DataGridViewImageColumn)dataGridViewMatHang.Columns[3];
            picCol.ImageLayout = DataGridViewImageCellLayout.Stretch;

            getImageAndUsername();
            //check giỏ hàng
            giohang();
            //hien thi gio hang
         

            StyleDatagridview();


        }

        private void dataGridViewMatHang_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            textBoxMaHang.Text = dataGridViewMatHang.CurrentRow.Cells[0].Value.ToString();
            textBoxTenHang.Text = dataGridViewMatHang.CurrentRow.Cells[2].Value.ToString();
            textBoxGia.Text = dataGridViewMatHang.CurrentRow.Cells[4].Value.ToString();
            byte[] pic;
            pic = (byte[])dataGridViewMatHang.CurrentRow.Cells[3].Value;
            MemoryStream picture = new MemoryStream(pic);
            pictureBoxHinh.Image = Image.FromStream(picture);
            double value = Convert.ToDouble(textBoxGia.Text);
            textBoxGia.Text = string.Format(new CultureInfo("vi-VN"), "{0:#,##0}", value);
        }

        private void buttonThem_Click_1(object sender, EventArgs e)
        {
            

                if (checkrong() == false)
                {
                    MessageBox.Show("Vui lòng điền đầy đủ thông mặt hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    try
                    {
                        int mskh = GLOBALS.GlobalUserId;
                        string tenhang = textBoxTenHang.Text;
                        int mahang = Convert.ToInt32(textBoxMaHang.Text);
                        int magiohang = GLOBALS.GlobalUserId;
                        double gia = Convert.ToDouble(textBoxGia.Text);
                        int soluong = Convert.ToInt32(numericSoLuong.Text);
                        double tonggia = gia * soluong;
                        if (check2 == true) //áp dụng mã giảm giá
                        {
                            tonggia = tonggia - tonggia * coupon;
                        }
                        if (muahang.themhangvaogio(magiohang, mahang, tenhang, soluong, tonggia, mskh))
                        {
                            //muahang.lichsugiohang(magiohang, mahang, tenhang, soluong, tonggia, mskh);
                            MessageBox.Show("Thêm thành công", "Hàng hóa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            giohang();
                            refresh();
                            refresh2();
                        }
                        else
                        {
                            MessageBox.Show("Lỗi", "Hàng hóa", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Vui lòng kiểm tra lại thông tin nhập", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
                bool checkrong()
                {
                    if (textBoxGia.Text.Trim() == "" || textBoxMaHang.Text.Trim() == "" || pictureBoxHinh.Image == null)
                    {
                        return false;
                    }
                    else
                        return true;
                }
            
        }

        private void button3_Click_1(object sender, EventArgs e)
        {

            if (check == false)
            {
                MessageBox.Show("Khách hàng đang có giỏ hàng", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                this.Hide();
                ChonGioHang chongh = new ChonGioHang();
                chongh.ShowDialog();
                this.Close();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int mskh = GLOBALS.GlobalUserId;
            GioHangForm giohang = new GioHangForm(mskh, tenkh);
            giohang.ShowDialog();
            refresh2();
        }

        private void pictureBoxGioHang_Click_1(object sender, EventArgs e)
        {

           
        }

        private void dataGridViewMatHang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        
    }
}
