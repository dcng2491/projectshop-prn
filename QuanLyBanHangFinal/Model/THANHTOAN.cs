using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBanHangFinal.Model
{
    class THANHTOAN
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
        public bool thanhtoan(int mahoadon, int msnv, DateTime ngaythanhtoan, double tongtien)
        {
            string connectionString = getConnect();
            SqlConnection connection = new SqlConnection(connectionString);

            SqlCommand command = new SqlCommand("INSERT INTO THANHTOAN (mahoadon,msnv,ngaythanhtoan,tongtien)" + "VALUES (@mhd,@msnv,@ntt,@tt)", connection);
            command.Parameters.Add("@mhd", SqlDbType.Int).Value = mahoadon;
            command.Parameters.Add("@msnv", SqlDbType.Int).Value = msnv;
            command.Parameters.Add("@ntt", SqlDbType.DateTime).Value = ngaythanhtoan;
            command.Parameters.Add("@tt", SqlDbType.Int).Value = tongtien;
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
        public bool updatetrangthai(int mahoadon, int mskh)
        {
            string connectionString = getConnect();
            SqlConnection connection = new SqlConnection(connectionString);


            SqlCommand command = new SqlCommand("UPDATE HOADON SET trangthai=1 WHERE mahoadon=@mhd AND mskh=@mskh", connection);
            command.Parameters.Add("@mhd", SqlDbType.Int).Value = mahoadon;
            command.Parameters.Add("@mskh", SqlDbType.Int).Value = mskh;
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
        public bool kiguihoadon(int mahoadon, int mskh)
        {
            string connectionString = getConnect();
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand("UPDATE HOADON SET trangthai=2 WHERE mahoadon=@mhd AND mskh=@mskh", connection);
            command.Parameters.Add("@mhd", SqlDbType.Int).Value = mahoadon;
            command.Parameters.Add("@mskh", SqlDbType.Int).Value = mskh;
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
        public bool mokiguihoadon(int mahoadon, int mskh)
        {
            string connectionString = getConnect();
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand("UPDATE HOADON SET trangthai=0 WHERE mahoadon=@mhd AND mskh=@mskh", connection);
            command.Parameters.Add("@mhd", SqlDbType.Int).Value = mahoadon;
            command.Parameters.Add("@mskh", SqlDbType.Int).Value = mskh;
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


        public void xoahethangtronggio(int magiohang, int mskh)
        {
            try
            {
                string connectionString = getConnect();
                SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();
                string query = $"DELETE FROM dbo.GIOHANG WHERE magiohang={magiohang} AND mskh={mskh} ";
                SqlCommand command = new SqlCommand(query, connection);
                command = connection.CreateCommand();
                command.CommandText = query;
                command.ExecuteNonQuery();


                connection.Close();
            }
            catch
            {

                MessageBox.Show("Success");
            }
                 
                //BindGrid();
            


            
            

        }




        public bool trangthaithanhtoan(int magiohang, int mskh)
        {
            string connectionString = getConnect();
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand("UPDATE GIOHANG SET thanhtoan=1 WHERE magiohang=@mgh AND mskh=@mskh", connection);
            command.Parameters.Add("@mgh", SqlDbType.Int).Value = magiohang;
            command.Parameters.Add("@mskh", SqlDbType.Int).Value = mskh;
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

    }
}
