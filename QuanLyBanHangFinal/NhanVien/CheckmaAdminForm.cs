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
    public partial class CheckmaAdminForm : Form
    {
        KHACHHANG kh = new KHACHHANG();
        private int mskh;
        private string tenkh;
        public CheckmaAdminForm()
        {
            InitializeComponent();
        }
        public CheckmaAdminForm(int mskh, string tenkh)
        {
            InitializeComponent();
            this.mskh = mskh;
            this.tenkh = tenkh;
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
        private void customButton1_Click(object sender, EventArgs e)
        {

            if (textBoxCustom1.Text.Trim() == "")
            {
                MessageBox.Show("Nhập mã xác nhận", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                string connectionString = getConnect();
                SqlConnection connection = new SqlConnection(connectionString);
                SqlDataAdapter adapter = new SqlDataAdapter();
                DataTable table = new DataTable();
                SqlCommand command = new SqlCommand("SELECT * FROM QUANLY WHERE password = @Pass", connection);
                command.Parameters.Add("@Pass", SqlDbType.VarChar).Value = textBoxCustom1.Text;
                adapter.SelectCommand = command;
                adapter.Fill(table);
                if ((table.Rows.Count > 0))
                {
                    this.Hide();
                    DoiMKForm doimk = new DoiMKForm(mskh, tenkh);
                    doimk.ShowDialog();
                    this.Focus();
                }
                else
                {
                    MessageBox.Show("Invalid Password", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void customButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
