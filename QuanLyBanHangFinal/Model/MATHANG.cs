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
    class MATHANG
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
        public bool themhang(int mahang, string loaihang, string tenhang, MemoryStream hinh, double gia, int soluong)
        {
            string connectionString = getConnect();
            SqlConnection connection = new SqlConnection(connectionString);

            SqlCommand command = new SqlCommand("INSERT INTO HANGHOA (mahang,loaihang,tenhang,hinh,gia,soluong)" + "VALUES (@mh,@lh,@th,@hinh,@gia,@sl)", connection);
            command.Parameters.Add("@mh", SqlDbType.Int).Value = mahang;
            command.Parameters.Add("@lh", SqlDbType.NVarChar).Value = loaihang;
            command.Parameters.Add("@th", SqlDbType.NVarChar).Value = tenhang;
            command.Parameters.Add("@hinh", SqlDbType.Image).Value = hinh.ToArray();
            command.Parameters.Add("@gia", SqlDbType.Float).Value = gia;
            command.Parameters.Add("@sl", SqlDbType.Int).Value = soluong;
            connection.Open();
            //()
            if ((command.ExecuteNonQuery() == -1))
            {
                connection.Close();
                return false;
            }
            else
            {
                connection.Close();
                return true;
            }
        }
        public bool checkID(int id)
        {
            string connectionString = getConnect();
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand("SELECT * FROM HANGHOA WHERE mahang=" + id, connection);
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
        public DataTable layHangHoa(SqlCommand command)
        {
            string connectionString = getConnect();
            SqlConnection connection = new SqlConnection(connectionString);
            command.Connection = connection;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;

        }
        public bool checkten(string tenhang)
        {
            string connectionString = getConnect();
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand("SELECT * FROM HANGHOA WHERE tenhang=@th", connection);
            command.Parameters.Add("@th", SqlDbType.VarChar).Value = tenhang;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            if (table.Rows.Count > 0)
            {
                //neu phat hien cos 1 dong ton tai trung ten
                return false;
            }
            else
            {
                return true;
            }
        }
        public bool update2(String tensp, int soluong)
        {
            string connectionString = getConnect();
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand("UPDATE HANGHOA SET soluong=@sl WHERE tenhang=@mh", connection);
            command.Parameters.Add("@th", SqlDbType.NVarChar).Value = tensp;
            command.Parameters.Add("@sl", SqlDbType.Int).Value = soluong;
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
        public bool Xoahang(int id)
        {
            string connectionString = getConnect();
            SqlConnection connection = new SqlConnection(connectionString);

            SqlCommand command = new SqlCommand("DELETE FROM HANGHOA where mahang=" + id, connection);
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
        public bool updateHang(int mahang, string loaihang, string tenhang, MemoryStream hinh, double gia, int soluong)
        {
            string connectionString = getConnect();
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand("UPDATE HANGHOA SET loaihang=@lh,tenhang=@th,hinh=@hinh,gia=@gia,soluong=@sl WHERE mahang=@mh", connection);
            command.Parameters.Add("@mh", SqlDbType.Int).Value = mahang;
            command.Parameters.Add("@lh", SqlDbType.NVarChar).Value = loaihang;
            command.Parameters.Add("@th", SqlDbType.NVarChar).Value = tenhang;
            command.Parameters.Add("@hinh", SqlDbType.Image).Value = hinh.ToArray();
            command.Parameters.Add("@gia", SqlDbType.Float).Value = gia;
            command.Parameters.Add("@sl", SqlDbType.Int).Value = soluong;

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
        
        public string tongmathang()
        {
            string connectionString = getConnect();
            SqlConnection connection = new SqlConnection(connectionString);


            string count = "";
            SqlCommand command = new SqlCommand("SELECT COUNT(tenhang) FROM dbo.HANGHOA", connection);
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    count = reader[0].ToString();
                }
            }
            reader.Close();
            //count = (Int32)command.ExecuteScalar();
            connection.Close();
            return count;
        }
        
        
    }
}
