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
    class DOANHTHU
    {
      
        public bool addDoanhthu(double tien, DateTime ngay)
        {
            string connectionString = getConnect();
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand("INSERT INTO DOANHTHU (tien,ngay)" + "VALUES (@tien,@ngay)", connection);
            command.Parameters.Add("@tien", SqlDbType.Float).Value = tien;
            command.Parameters.Add("@ngay", SqlDbType.DateTime).Value = ngay;
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

        public DataTable layDoanhThu(SqlCommand command)
        {
            string connectionString = getConnect();
            SqlConnection connection = new SqlConnection(connectionString);

            command.Connection = connection;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;

        }
        public Int32 doanhthutungthang()
        {
            string connectionString = getConnect();
            SqlConnection connection = new SqlConnection(connectionString);
            Int32 count = 0;
            SqlCommand command = new SqlCommand("SELECT COUNT(*) FROM std", connection);
            connection.Open();
             count = (Int32)command.ExecuteScalar();
            connection.Close();
            return count;
        }
    }
}
