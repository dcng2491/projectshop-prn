using Microsoft.Extensions.Configuration;
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

namespace QuanLyBanHangFinal.Admin
{
    public partial class ChamCongAD : Form
    {
        string connectionString;
        public ChamCongAD()
        {
            InitializeComponent();
            BindGrid();
        }

        public string getConnect()
        {

            var conf = new ConfigurationBuilder()
              .SetBasePath(Directory.GetCurrentDirectory())


              .AddJsonFile("appsettings.json", true, true)

              .Build();
            connectionString = conf.GetConnectionString("DbConnection");


            return connectionString;

        }
        private void BindGrid()
        {

            DateTime now = DateTime.Now;
            string thang = $"thang {now.Month}";
            labelMonth.Text = $"Tháng {now.Month}";
            
            string connectionString = getConnect();

            SqlConnection connection = new SqlConnection(connectionString);

            connection.Open();
            string query = $"select *from mytable where Month like '%{thang}%'";
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);


            DataTable table = new DataTable();
            adapter.Fill(table);

            dataGridView1.DataSource = table;
            this.dataGridView1.Columns["Month"].Visible = false;
            dataGridView1.Columns["NVName"].ReadOnly = true;

            if (now.Month.Equals(4) || now.Month.Equals(6) || now.Month.Equals(9) || now.Month.Equals(11))
            {
                this.dataGridView1.Columns["Ngay31"].Visible = false;
            }
            if (now.Month.Equals(2))
            {
                this.dataGridView1.Columns["Ngay30"].Visible = false;
                this.dataGridView1.Columns["Ngay31"].Visible = false;
            }
            connection.Close();
        }

        

      
        private void UpdateChamCong(string ngay, string ten, string thang)
        {
            string value = "False";
            if (checkBox1.Checked == true)
            {
                value = "true";

            }




            try
            {
                string connectionString = getConnect();
                SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();
                string query = $"UPDATE [mytable]  SET   {ngay}= '{value}' WHERE NVName='{ten}' and MONTH='{thang}'";
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

        

      

        private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            int columnIndex = dataGridView1.CurrentCell.ColumnIndex;
            string Ngay = dataGridView1.Columns[columnIndex].Name;

            //row.Cells["isStaff"].Value
            DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

            string tenNV = row.Cells["NVName"].Value.ToString();
            string thang = row.Cells["Month"].Value.ToString();

            string value = "";
            textBox1.Text = thang;
            textBox2.Text = tenNV;
            textBox3.Text = Ngay;
            if ((bool)row.Cells[Ngay].Value) { checkBox1.Checked = true; }
            else { checkBox1.Checked = false; }

        }

        private void btnTim_Click_1(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            checkBox1.Checked = false;
            string connectionString = getConnect();

            SqlConnection connection = new SqlConnection(connectionString);
            DateTime now = DateTime.Now;
            labelMonth.Text = $"Tháng {now.Month}";

            if (radioMonth.Checked)
            {

                connection.Open();
                string query = "select *from mytable where Month like '%" + txtSearch.Text + "%'";
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);


                DataTable table = new DataTable();
                adapter.Fill(table);

                dataGridView1.DataSource = table;
                this.dataGridView1.Columns["Month"].Visible = false;
                 
                labelMonth.Text = $"Tháng {txtSearch.Text}";
                if (txtSearch.Text.Equals("4") || txtSearch.Text.Equals("6") || txtSearch.Text.Equals("9") || txtSearch.Text.Equals("11"))
                {
                    this.dataGridView1.Columns["Ngay31"].Visible = false;

                }
                else if (txtSearch.Text.Equals("2"))
                {
                    this.dataGridView1.Columns["Ngay31"].Visible = false;
                    this.dataGridView1.Columns["Ngay30"].Visible = false;
                }
                else
                {
                    this.dataGridView1.Columns["Ngay31"].Visible = true;
                    this.dataGridView1.Columns["Ngay30"].Visible = true;

                }
                connection.Close();

            }
            if (radioTenNV.Checked)
            {


                connection.Open();
                string query = "select *from mytable where NVName like '%" + txtSearch.Text + "%'";
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);


                DataTable table = new DataTable();
                adapter.Fill(table);

                dataGridView1.DataSource = table;
                this.dataGridView1.Columns["Month"].Visible = false;
                connection.Close();
            }

        }

        private void btnList_Click_1(object sender, EventArgs e)
        {
            string connectionString = getConnect();

            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            string query = "select *from mytable";
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);


            DataTable table = new DataTable();
            adapter.Fill(table);

            dataGridView1.DataSource = table;
            this.dataGridView1.Columns["Month"].Visible = false;
            connection.Close();

        }

        private void btnSave_Click_1(object sender, EventArgs e)
        {
            UpdateChamCong(textBox3.Text, textBox2.Text, textBox1.Text);
            MessageBox.Show("Update success");
            BindGrid();
        }
    }
}
