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
    class HOADON
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
        public bool themvaohoadon(int mskh, int magiohang, double tongtien, DateTime ngaymua)
        {
            string connectionString = getConnect();

            SqlConnection connection = new SqlConnection(connectionString);

            SqlCommand command = new SqlCommand("INSERT INTO HOADON (mskh,magiohang,tongtien,ngaymua)" + "VALUES (@mskh,@mgh,@tt,@nm)", connection);

            command.Parameters.Add("@mskh", SqlDbType.Int).Value = mskh;
            command.Parameters.Add("@mgh", SqlDbType.Int).Value = magiohang;
            command.Parameters.Add("@tt", SqlDbType.Float).Value = tongtien;
            command.Parameters.Add("@nm", SqlDbType.DateTime).Value = ngaymua;
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
        public bool kthoadon(int mskh)
        {
            string connectionString = getConnect();

            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand("SELECT * FROM HOADON WHERE  mskh=" + mskh + "AND trangthai=0", connection);
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
        public bool Xoahang(int mahang, int magiohang)
        {
            string connectionString = getConnect();
            SqlConnection connection = new SqlConnection(connectionString);



            SqlCommand command = new SqlCommand("DELETE FROM GIOHANG where mahang=" + mahang + "AND magiohang=" + magiohang, connection);
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
        public bool HuyHoaDon(int mahoadon, int makh)
        {
            string connectionString = getConnect();
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand("DELETE FROM HOADON where mahoadon=" + mahoadon + "AND mskh=" + makh, connection);
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
