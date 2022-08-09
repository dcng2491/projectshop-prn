using Microsoft.Extensions.Configuration;
using QuanLyBanHangFinal.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBanHangFinal.NhanVien
{
    public partial class DoiMKForm : Form
    {
        private int mskh;
        private string tenkh;
        public DoiMKForm()
        {
            InitializeComponent();
        }
        public DoiMKForm(int mskh, string tenkh)
        {
            InitializeComponent();
            this.mskh = mskh;
            this.tenkh = tenkh;
        }
        private void buttonXacNhan_Click(object sender, EventArgs e)
        {
            KHACHHANG kh = new KHACHHANG();
            string username = textBoxUser.Text;
            string password = textBoxPass.Text;
            string repassword = textBoxRePass.Text;
            if (verif() == true)
            {

                if (kh.update_user_pass(mskh, username, repassword))
                {
                    MessageBox.Show("Đã cập nhật", "Khách hàng", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Lỗi", "Khách hàng", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Error", "Khách hàng", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        bool verif()
        {
            if ((textBoxUser.Text.Trim() == "") || (textBoxPass.Text.Trim() == "") || (textBoxRePass.Text.Trim() == ""))
            {
                return false;
            }
            else
            {
                return true;
            }
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


        private void DoiMKForm_Load(object sender, EventArgs e)
        {
            string connectionString = getConnect();
            SqlConnection connection = new SqlConnection(connectionString);
            labelTenKh.Text = "Khách hàng: " + tenkh;
            SqlCommand command = new SqlCommand("SELECT * FROM KHACHHANG WHERE mskh=" + mskh, connection);
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            reader.Read();
            if (reader.HasRows)
            {
                textBoxUser.Text = reader["username"] + "";
                textBoxPass.Text = reader["password"] + "";
            }
            reader.Close();
            connection.Close();
        }

        private void buttonXacNhan_Click_1(object sender, EventArgs e)
        {
            KHACHHANG kh = new KHACHHANG();
            string username = textBoxUser.Text;
            string password = textBoxPass.Text;
            string repassword = textBoxRePass.Text;
            if (verif() == true)
            {

                if (kh.update_user_pass(mskh, username, repassword))
                {
                    MessageBox.Show("Đã cập nhật", "Khách hàng", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Lỗi", "Khách hàng", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Error", "Khách hàng", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
