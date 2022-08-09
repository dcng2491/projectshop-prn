using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanHangFinal.MuaHang
{
    class MUAHANG
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
        public bool themhangvaogio(int magiohang, int mahang, string tenhang, int soluong, double gia, int mskh)
        {
            string connectionString = getConnect();

            SqlConnection connection = new SqlConnection(connectionString);

            SqlCommand command = new SqlCommand("INSERT INTO GIOHANG (magiohang,mahang,tenhang,soluong,gia,mskh)" + "VALUES (@mgh,@mh,@th,@sl,@gia,@mskh)", connection);
            command.Parameters.Add("@mgh", SqlDbType.Int).Value = magiohang;
            command.Parameters.Add("@mh", SqlDbType.Int).Value = mahang;
            command.Parameters.Add("@th", SqlDbType.NVarChar).Value = tenhang;
            command.Parameters.Add("@gia", SqlDbType.Float).Value = gia;
            command.Parameters.Add("@sl", SqlDbType.Int).Value = soluong;
            command.Parameters.Add("@mskh", SqlDbType.Int).Value = mskh;
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
        //public bool lichsugiohang(int magiohang, int mahang, string tenhang, int soluong, double gia, int mskh, DateTime ngay)
        //{
        //    string connectionString = getConnect();

        //    SqlConnection connection = new SqlConnection(connectionString);

        //    SqlCommand command = new SqlCommand("INSERT INTO LICHSU_GIOHANG (magiohang,mahang,tenhang,soluong,gia,mskh,ngay)" + "VALUES (@mgh,@mh,@th,@sl,@gia,@mskh,@ngay)", connection);
        //    command.Parameters.Add("@mgh", SqlDbType.Int).Value = magiohang;
        //    command.Parameters.Add("@mh", SqlDbType.Int).Value = mahang;
        //    command.Parameters.Add("@th", SqlDbType.NVarChar).Value = tenhang;
        //    command.Parameters.Add("@gia", SqlDbType.Float).Value = gia;
        //    command.Parameters.Add("@sl", SqlDbType.Int).Value = soluong;
        //    command.Parameters.Add("@mskh", SqlDbType.Int).Value = mskh;
        //    command.Parameters.Add("@ngay", SqlDbType.DateTime).Value = ngay;
        //    connection.Open();
        //    //()
        //    if ((command.ExecuteNonQuery() == -1))
        //    {
        //        connection.Close();
        //        return false;
        //    }
        //    else
        //    {
        //        connection.Close();
        //        return true;
        //    }
        //}
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

            SqlCommand command = new SqlCommand("SELECT * FROM GIOHANG WHERE tenhang=@th", connection);
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
        public bool checkID(int id)
        {
            string connectionString = getConnect();

            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand("SELECT * FROM GIOHANG WHERE mahang=" + id, connection);
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
        public bool Xoahang(int stt, int mahang, int magiohang)
        {
            string connectionString = getConnect();

            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand("DELETE FROM GIOHANG where mahang=" + mahang + "AND magiohang=" + magiohang + "AND stt=" + stt, connection);
            connection.Open();

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
        public bool kiemtragiohang(int magiohang)
        {
            string connectionString = getConnect();

            SqlConnection connection = new SqlConnection(connectionString);

            SqlCommand command = new SqlCommand("SELECT * FROM GIOHANG WHERE magiohang=" + magiohang, connection);
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
        public bool updateHang(int magiohang, int mahang, string tenhang, int soluong, double gia, int mskh)
        {
            string connectionString = getConnect();

            SqlConnection connection = new SqlConnection(connectionString);

            SqlCommand command = new SqlCommand("UPDATE GIOHANG SET mahang=@mh,tenhang=@th,soluong=@sl,gia=@gia,msnv=@msnv,mskh=@mskh WHERE magiohang=@mgh", connection);
            command.Parameters.Add("@mgh", SqlDbType.Int).Value = magiohang;
            command.Parameters.Add("@mh", SqlDbType.Int).Value = mahang;
            command.Parameters.Add("@th", SqlDbType.NVarChar).Value = tenhang;
            command.Parameters.Add("@gia", SqlDbType.Float).Value = gia;
            command.Parameters.Add("@sl", SqlDbType.Int).Value = soluong;
            command.Parameters.Add("@mskh", SqlDbType.Int).Value = mskh;

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
        public string tongtien(int mskh)
        {
            string connectionString = getConnect();

            SqlConnection connection = new SqlConnection(connectionString);

            string count = "";
            SqlCommand command = new SqlCommand("SELECT SUM(gia) FROM dbo.GIOHANG WHERE mskh=" + mskh, connection);
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
