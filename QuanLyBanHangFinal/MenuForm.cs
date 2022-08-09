using Microsoft.Extensions.Configuration;
using QuanLyBanHangFinal.Model;
using QuanLyBanHangFinal.NhanVien;
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



    public partial class MenuForm : Form
    {
        string connectionString;
        string ngayyy;
        private DateTime giovao;
        public MenuForm()
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





        public MenuForm(DateTime giovao)
        {
            InitializeComponent();
            this.giovao = giovao;
        }
        private void quảnLýKháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void kháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelMenu.Controls.Clear();
            panelMenu.Controls.Add(new QuanLyKHForm());
        }

        private void buttonThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void mặtHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {

            panelMenu.Controls.Clear();
            panelMenu.Controls.Add(new MatHangForm());
        }

        private void muaHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void MenuForm_Load(object sender, EventArgs e)
        {
           

        }
        string laytennv(int msnv)
        {
            string connectionString = getConnect();

            SqlConnection connection = new SqlConnection(connectionString);

            msnv = GLOBALS.GlobalUserId;
            string tennv = "";
            SqlCommand command2 = new SqlCommand("SELECT * FROM dbo.NHANVIEN WHERE msnv=" + msnv, connection);
            connection.Open();
            SqlDataReader reader = command2.ExecuteReader();
            if (reader.HasRows)
            {
                reader.Read();
                tennv = reader["hoten"].ToString();
            }
            reader.Close();
            return tennv;
        }
        private void buttonThoat_Click_1(object sender, EventArgs e)
        {
            
            int msnv = GLOBALS.GlobalUserId;
            string tennv = laytennv(msnv);
            DateTime giora = DateTime.Now;
            TimeSpan check = giovao - giora;
            int sogio = Math.Abs(check.Hours);
           
            Close();
        }

        private void buttonDangXuat_Click(object sender, EventArgs e)
        {
           
            int msnv = GLOBALS.GlobalUserId;
            string tennv = laytennv(msnv);
            DateTime giora = DateTime.Now;
            TimeSpan check = giovao - giora;
            int sogio = Math.Abs(check.Hours);
           
            this.Hide();
            Form1 lo = new Form1();
            lo.ShowDialog();
        }

        private void hóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelMenu.Controls.Clear();
            panelMenu.Controls.Add(new HoaDonForm());
        }

        private void panelMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void mặtHàngToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            panelMenu.Controls.Clear();
            panelMenu.Controls.Add(new MatHangForm());
        }

        private void kháchHàngToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            panelMenu.Controls.Clear();
            panelMenu.Controls.Add(new HoaDonForm());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panelMenu.Controls.Clear();
            panelMenu.Controls.Add(new QuanLyKHForm());
        }

        private void buttonThoat_Click_2(object sender, EventArgs e)
        {
           
            int msnv = GLOBALS.GlobalUserId;
            string tennv = laytennv(msnv);
            DateTime giora = DateTime.Now;
            TimeSpan check = giovao - giora;
            int sogio = Math.Abs(check.Hours);
           
            Close();
        }

        private void buttonDangXuat_Click_1(object sender, EventArgs e)
        {
            
            int msnv = GLOBALS.GlobalUserId;
            string tennv = laytennv(msnv);
            DateTime giora = DateTime.Now;
            TimeSpan check = giovao - giora;
            int sogio = Math.Abs(check.Hours);
          
            this.Hide();
            Form1 lo = new Form1();
            lo.ShowDialog();
        }

        public string getImageAndUsername()
        { string nameee ="";
           
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
              
             
                nameee= table.Rows[0]["username"].ToString();
               
            }
            return nameee;
        }



        private void UpdateDiemDanh(string thang,string ngay,string name)
        {
            try
            {
                string connectionString = getConnect();
                SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();
                string query = $"UPDATE [dbo].[mytable]SET [Month] = '{thang}',{ngay} = 'true' WHERE NVName='{name}'";
                SqlCommand command = new SqlCommand(query, connection);
                command = connection.CreateCommand();
                command.CommandText = query;
                command.ExecuteNonQuery();


                connection.Close();
                //BindGrid();
            }
            catch
            {
                MessageBox.Show("Cannot Update");
            }
        }
        private void btnDiemDanh_Click(object sender, EventArgs e)
        {




            /*DateTime now = DateTime.Now;
            string thang = $"thang {now.Month}";
            string ngay = $"ngay{now.Day}";
            string name = getImageAndUsername();
            try
            {
                UpdateDiemDanh(thang, ngay, name);
                MessageBox.Show("Điểm danh thành công");
                btnDiemDanh.Hide();


            }
            catch
            {
                MessageBox.Show("Điểm danh thất bại");
            }*/




        }

        private void panelMenu_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void MenuForm_Load_1(object sender, EventArgs e)
        {
            //dataGridView1.Hide();
          
            

        }
    }
}
