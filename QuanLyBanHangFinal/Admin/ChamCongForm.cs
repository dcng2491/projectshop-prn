using QuanLyBanHangFinal.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBanHangFinal.Admin
{
    public partial class ChamCongForm : Form
    {
        NHANVIEN nv = new NHANVIEN();
        
        public ChamCongForm()
        {
            InitializeComponent();
        }

        private void ChamCongForm_Load(object sender, EventArgs e)
        {
            StyleDatagridview();
        }
        void StyleDatagridview()
        {
            SqlCommand command = new SqlCommand("SELECT msnv as 'Mã nhân viên',hoten as 'Họ và tên',giovao as 'Giờ vào',giora as 'Giờ ra',sogio as 'Tiếng' FROM CHAMCONG");
            dataGridViewChamCong.DataSource = nv.layNV(command);
            dataGridViewChamCong.ReadOnly = true;
            dataGridViewChamCong.RowTemplate.Height = 60;
            dataGridViewChamCong.BorderStyle = BorderStyle.None;
            dataGridViewChamCong.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dataGridViewChamCong.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewChamCong.DefaultCellStyle.SelectionBackColor = Color.SeaGreen;
            dataGridViewChamCong.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dataGridViewChamCong.BackgroundColor = Color.FromArgb(148, 184, 184);
            dataGridViewChamCong.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewChamCong.EnableHeadersVisualStyles = false;
            dataGridViewChamCong.AllowUserToAddRows = false;
            dataGridViewChamCong.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewChamCong.ColumnHeadersDefaultCellStyle.Font = new Font("Times New Roman", 12);

            //dòng tiêu đề của bảng
            dataGridViewChamCong.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(58, 95, 95);
            dataGridViewChamCong.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            //căn giữa 
            dataGridViewChamCong.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

        }
    }
}
