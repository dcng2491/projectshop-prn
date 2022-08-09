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
    class NHANVIEN
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


        public bool themNVChamCong(string thang,string username)
        {
            string connectionString = getConnect();
            SqlConnection connection = new SqlConnection(connectionString);


            SqlCommand command = new SqlCommand("INSERT INTO [mytable] ([Month] ,[NVName])" + "VALUES (@thang, @user)", connection);
            command.Parameters.Add("@thang", SqlDbType.VarChar).Value = thang;
            command.Parameters.Add("@user", SqlDbType.VarChar).Value = username;
             


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





        public bool themNV(string hoten, string gioitinh, DateTime namsinh, string diachi, MemoryStream hinh, string username, string password)
        {
            string connectionString = getConnect();
            SqlConnection connection = new SqlConnection(connectionString);


            SqlCommand command = new SqlCommand("INSERT INTO NHANVIEN (hoten,gioitinh,namsinh,diachi,hinh,username,password)" + "VALUES ( @ht, @gt, @ns, @dc, @hinh, @user, @pass)", connection);
             
            command.Parameters.Add("@ht", SqlDbType.NVarChar).Value = hoten;
            command.Parameters.Add("@gt", SqlDbType.NVarChar).Value = gioitinh;
            command.Parameters.Add("@ns", SqlDbType.DateTime).Value = namsinh;
            command.Parameters.Add("@dc", SqlDbType.NVarChar).Value = diachi;
            command.Parameters.Add("@hinh", SqlDbType.Image).Value = hinh.ToArray();
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
        public bool checkID(int msnv)
        {
            string connectionString = getConnect();
            SqlConnection connection = new SqlConnection(connectionString);

            SqlCommand command = new SqlCommand("SELECT * FROM NHANVIEN WHERE msnv=" + msnv, connection);
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

        public DataTable layNV(SqlCommand command)
        {
            string connectionString = getConnect();
            SqlConnection connection = new SqlConnection(connectionString);

            command.Connection = connection;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;

        }
        public bool XoaNV(int msnv)
        {
            string connectionString = getConnect();
            SqlConnection connection = new SqlConnection(connectionString);

            SqlCommand command = new SqlCommand("DELETE FROM NHANVIEN where msnv=" + msnv, connection);
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
        public bool suaNV(int msnv, string hoten, string gioitinh, DateTime namsinh, string diachi, MemoryStream hinh, string username, string password)
        {
            string connectionString = getConnect();
            SqlConnection connection = new SqlConnection(connectionString);


            SqlCommand command = new SqlCommand("UPDATE NHANVIEN SET hoten=@ht,gioitinh=@gt,namsinh=@ns,diachi=@dc,hinh=@hinh,username=@user,password=@pass WHERE msnv=@msnv", connection);
            command.Parameters.Add("@msnv", SqlDbType.Int).Value = msnv;
            command.Parameters.Add("@ht", SqlDbType.NVarChar).Value = hoten;
            command.Parameters.Add("@gt", SqlDbType.NVarChar).Value = gioitinh;
            command.Parameters.Add("@ns", SqlDbType.DateTime).Value = namsinh;
            command.Parameters.Add("@dc", SqlDbType.NVarChar).Value = diachi;
            command.Parameters.Add("@hinh", SqlDbType.Image).Value = hinh.ToArray();
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
