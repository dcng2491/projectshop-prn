using Microsoft.Extensions.Configuration;
using QuanLyBanHangFinal.Model;
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
    public partial class ThemNVForm : Form
    {
        NHANVIEN nv = new NHANVIEN();
        public ThemNVForm()
        {
            InitializeComponent();
        }


        public string getConnect()
        {
            string connectionString;

            var conf = new ConfigurationBuilder()
              .SetBasePath(Directory.GetCurrentDirectory())


              .AddJsonFile("appsettings.json", true, true)

              .Build();
            connectionString = conf.GetConnectionString("DbConnection");


            return connectionString;

        }
        void refresh()
        {
            textBoxDiaChi.Text = "";
            textBoxHoten.Text = "";
            textBoxPassword.Text = "";
            textBoxUsername.Text = "";
            radioButtonNam.Checked = false;
            radioButtonNu.Checked = false;
            pictureBoxAnhDaiDien.Image = null;
        }
        bool verif()
        {
            if ((textBoxHoten.Text.Trim() == "") || (textBoxDiaChi.Text.Trim() == "") || (textBoxPassword.Text.Trim() == "") || (textBoxUsername.Text.Trim() == "") || (pictureBoxAnhDaiDien.Image == null))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void buttonDong_Click(object sender, EventArgs e)
        {
            Close();
        }

       




        private void buttonThem_Click(object sender, EventArgs e)
        {
            if (verif() == false)
            {
                MessageBox.Show("Nhập thông tin", "LỖI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
               
                    string hoten = textBoxHoten.Text;
                    string diachi = textBoxDiaChi.Text;
                    DateTime namsinh = dateTimePickerNamSinh.Value;
                    string username = textBoxUsername.Text;
                    string password = textBoxPassword.Text;
                    string gioitinh = "Nam";

                    if (radioButtonNu.Checked)
                    {
                        gioitinh = "Nữ";
                    }

                    MemoryStream hinh = new MemoryStream();
                    int born_year = dateTimePickerNamSinh.Value.Year;
                    int this_year = DateTime.Now.Year;
                    //ràng buộc dữ liệu về độ tuổi(ko cho người dùng nhập sai)
                    //svv từ 10-100
                    if (((this_year - born_year) < 10) || ((this_year - born_year) > 100))
                    {
                        MessageBox.Show("Độ tuổi phải trong khoảng từ 10-100", "Nhập sai", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                   
                    else if (verif())
                    {
                        DateTime now = DateTime.Now;
                        string thang = $"thang {now.Month}";
                        pictureBoxAnhDaiDien.Image.Save(hinh, pictureBoxAnhDaiDien.Image.RawFormat);

                        if (nv.themNVChamCong(thang,username))
                        {

                        }
                        if (nv.themNV( hoten, gioitinh, namsinh, diachi, hinh, username, password) )
                        {

                            MessageBox.Show("Thêm thành công", "Nhân viên", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            refresh();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Lỗi", "Nhân viên", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Empty Fields", "Nhân viên", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                
            }

            
        }

        private void ButtonUpload_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofp = new OpenFileDialog();
            ofp.Filter = "Select Image(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif";
            if ((ofp.ShowDialog() == DialogResult.OK))
            {
                pictureBoxAnhDaiDien.Image = Image.FromFile(ofp.FileName);
            }
        }
    }
}
