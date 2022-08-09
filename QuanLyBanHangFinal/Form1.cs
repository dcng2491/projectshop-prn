using Microsoft.Extensions.Configuration;
using QuanLyBanHangFinal.Admin;
using QuanLyBanHangFinal.Model;
using QuanLyBanHangFinal.MuaHang;
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

namespace QuanLyBanHangFinal
{
    public partial class Form1 : Form
    {
        string connectionString;
        public Form1()
        {
            InitializeComponent();
        }



        public string getConnect()
        {

            var conf = new ConfigurationBuilder()
              .SetBasePath(Directory.GetCurrentDirectory())

              //             need full path
              .AddJsonFile("appsettings.json", true, true)

              .Build();
            connectionString = conf.GetConnectionString("DbConnection");


            return connectionString;

        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            string connectionString = getConnect();
            SqlConnection connection = new SqlConnection(connectionString);

            connection.Open();

            if (radioButtonAdmin.Checked)
            {
                SqlDataAdapter adapter = new SqlDataAdapter();
                DataTable table = new DataTable();
                SqlCommand command = new SqlCommand("SELECT * FROM QUANLY WHERE username = @User AND password = @Pass", connection);
                command.Parameters.Add("@User", SqlDbType.VarChar).Value = textBoxUsername.Text;
                command.Parameters.Add("@Pass", SqlDbType.VarChar).Value = textBoxPassword.Text;
                adapter.SelectCommand = command;
                adapter.Fill(table);
                if ((table.Rows.Count > 0))
                {
                    QuanLyForm admin = new QuanLyForm();
                    this.Hide();
                    admin.ShowDialog();
                    this.Close();

                }
                else
                {
                    MessageBox.Show("Invalid Username or Password", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (radioButtonNV.Checked)
            {
                SqlDataAdapter adapter = new SqlDataAdapter();
                DataTable table = new DataTable();
                SqlCommand command = new SqlCommand("SELECT * FROM NHANVIEN WHERE username = @User AND password = @Pass", connection);
                command.Parameters.Add("@User", SqlDbType.VarChar).Value = textBoxUsername.Text;
                command.Parameters.Add("@Pass", SqlDbType.VarChar).Value = textBoxPassword.Text;
                adapter.SelectCommand = command;
                adapter.Fill(table);
                if ((table.Rows.Count > 0))
                {

                    int userid = Convert.ToInt16(table.Rows[0][0].ToString()); //mã số nhân viên
                    GLOBALS.setGlobalUserId(userid);
                    //
                   
                    DateTime giovao = DateTime.Now;
                   
                    //
                    MenuForm menu = new MenuForm(giovao);
                    this.Hide();
                    menu.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Invalid Username or Password", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else if (radioButtonKH.Checked)
            {
                SqlDataAdapter adapter = new SqlDataAdapter();
                DataTable table = new DataTable();
                SqlCommand command = new SqlCommand("SELECT * FROM KHACHHANG WHERE username = @User AND password = @Pass", connection);
                command.Parameters.Add("@User", SqlDbType.VarChar).Value = textBoxUsername.Text;
                command.Parameters.Add("@Pass", SqlDbType.VarChar).Value = textBoxPassword.Text;
                adapter.SelectCommand = command;
                adapter.Fill(table);
                if ((table.Rows.Count > 0))
                {
                    int userid = Convert.ToInt16(table.Rows[0][0].ToString());
                    GLOBALS.setGlobalUserId(userid);
                    KHForm khfrm = new KHForm();
                    this.Hide();
                    khfrm.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Invalid Username or Password", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Chọn quyền đăng nhập", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            connection.Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DKiKHForm dki = new DKiKHForm();
            dki.ShowDialog();
        }
    }
}
