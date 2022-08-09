using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanHangFinal.Model
{
    class KHACHHANG
    {
    

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

        public bool themKH(int mskh, string hoten, string gioitinh, DateTime namsinh, string diachi, string sdt, string username, string password)
        {
            string connectionString = getConnect();
            SqlConnection connection = new SqlConnection(connectionString);

            SqlCommand command = new SqlCommand("INSERT INTO KHACHHANG (hoten, gioitinh, namsinh, diachi, sdt, username, password)" + "VALUES (@ht, @gt, @ns, @dc, @sdt, @user, @pass)", connection);
           
            command.Parameters.Add("@ht", SqlDbType.NVarChar).Value = hoten;
            command.Parameters.Add("@gt", SqlDbType.NVarChar).Value = gioitinh;
            command.Parameters.Add("@ns", SqlDbType.DateTime).Value = namsinh;
            command.Parameters.Add("@dc", SqlDbType.NVarChar).Value = diachi;
            command.Parameters.Add("@sdt", SqlDbType.VarChar).Value = sdt;
            command.Parameters.Add("@user", SqlDbType.VarChar).Value = username;
            command.Parameters.Add("@pass", SqlDbType.VarChar).Value = password;


            connection.Open();

            if ((command.ExecuteNonQuery() == 1))
            {
                connection.Close();
                return true;
            }
            else
            {
                connection.Close();
                return false;
            }
        }
        public bool checkID(int id)
        {
            string connectionString = getConnect();
            SqlConnection connection = new SqlConnection(connectionString);

            SqlCommand command = new SqlCommand("SELECT * FROM KHACHHANG WHERE mskh=" + id, connection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);

            if ((table.Rows.Count == 0))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public DataTable layKH(SqlCommand command)
        {
            string connectionString = getConnect();
            SqlConnection connection = new SqlConnection(connectionString);

            command.Connection = connection;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;

        }
        public bool XoaKH(int mskh)
        {
            string connectionString = getConnect();
            SqlConnection connection = new SqlConnection(connectionString);

            SqlCommand command = new SqlCommand("DELETE FROM KHACHHANG where mskh=" + mskh, connection);
            connection.Open();
            if ((command.ExecuteNonQuery() == 1))
            {
                connection.Close();
                return true;

            }
            else
            {
                connection.Close();
                return false;
            }

        }
        public bool capnhatKH_chua_user_pass(int mskh, string hoten, string gioitinh, DateTime namsinh, string diachi, string sdt)
        {
            string connectionString = getConnect();
            SqlConnection connection = new SqlConnection(connectionString);

            SqlCommand command = new SqlCommand("UPDATE KHACHHANG SET hoten=@ht,gioitinh=@gt,namsinh=@ns,diachi=@dc,sdt=@sdt WHERE mskh=@mskh", connection);
            command.Parameters.Add("@mskh", SqlDbType.Int).Value = mskh;
            command.Parameters.Add("@ht", SqlDbType.NVarChar).Value = hoten;
            command.Parameters.Add("@gt", SqlDbType.NVarChar).Value = gioitinh;
            command.Parameters.Add("@ns", SqlDbType.DateTime).Value = namsinh;
            command.Parameters.Add("@dc", SqlDbType.NVarChar).Value = diachi;
            command.Parameters.Add("@sdt", SqlDbType.VarChar).Value = sdt;

            connection.Open();

            if (command.ExecuteNonQuery() == 1)
            {
                connection.Close();
                return true;
            }
            else
            {
                connection.Close();
                return false;
            }
        }
        public bool update_user_pass(int mskh, string username, string password)
        {
            string connectionString = getConnect();
            SqlConnection connection = new SqlConnection(connectionString);

            SqlCommand command = new SqlCommand("UPDATE KHACHHANG SET username=@user,password=@pass WHERE mskh=@mskh", connection);
            command.Parameters.Add("@mskh", SqlDbType.Int).Value = mskh;
            command.Parameters.Add("@user", SqlDbType.VarChar).Value = username;
            command.Parameters.Add("@pass", SqlDbType.VarChar).Value = password;
            connection.Open();

            if (command.ExecuteNonQuery() == 1)
            {
                connection.Close();

                return true;
            }
            else
            {
                connection.Close();
                return false;
            }

        }
    }
}
