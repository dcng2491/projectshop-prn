namespace QuanLyBanHangFinal.Admin
{
    partial class QuanLyForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridViewDoanhThu = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonQuanLyNV = new System.Windows.Forms.Button();
            this.buttonXoaNV = new System.Windows.Forms.Button();
            this.ButtonThemNV = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonChamCong = new System.Windows.Forms.Button();
            this.customButton1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnOUT = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.buttonThongKe = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDoanhThu)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(10, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(338, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bạn đang đăng nhập dưới quyền ADMIN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(557, 7);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 31);
            this.label2.TabIndex = 1;
            this.label2.Text = "Doanh Thu";
            // 
            // dataGridViewDoanhThu
            // 
            this.dataGridViewDoanhThu.AllowUserToAddRows = false;
            this.dataGridViewDoanhThu.AllowUserToDeleteRows = false;
            this.dataGridViewDoanhThu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDoanhThu.Location = new System.Drawing.Point(382, 68);
            this.dataGridViewDoanhThu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridViewDoanhThu.Name = "dataGridViewDoanhThu";
            this.dataGridViewDoanhThu.ReadOnly = true;
            this.dataGridViewDoanhThu.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridViewDoanhThu.RowTemplate.Height = 33;
            this.dataGridViewDoanhThu.Size = new System.Drawing.Size(449, 337);
            this.dataGridViewDoanhThu.TabIndex = 2;
            this.dataGridViewDoanhThu.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewDoanhThu_CellContentClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.buttonQuanLyNV);
            this.panel1.Controls.Add(this.buttonXoaNV);
            this.panel1.Controls.Add(this.ButtonThemNV);
            this.panel1.Location = new System.Drawing.Point(10, 410);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(839, 104);
            this.panel1.TabIndex = 3;
            // 
            // buttonQuanLyNV
            // 
            this.buttonQuanLyNV.Location = new System.Drawing.Point(565, 23);
            this.buttonQuanLyNV.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonQuanLyNV.Name = "buttonQuanLyNV";
            this.buttonQuanLyNV.Size = new System.Drawing.Size(187, 58);
            this.buttonQuanLyNV.TabIndex = 2;
            this.buttonQuanLyNV.Text = "Quản Lý Nhân Viên";
            this.buttonQuanLyNV.UseVisualStyleBackColor = true;
            this.buttonQuanLyNV.Click += new System.EventHandler(this.buttonQuanLyNV_Click);
            // 
            // buttonXoaNV
            // 
            this.buttonXoaNV.Location = new System.Drawing.Point(326, 23);
            this.buttonXoaNV.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonXoaNV.Name = "buttonXoaNV";
            this.buttonXoaNV.Size = new System.Drawing.Size(187, 58);
            this.buttonXoaNV.TabIndex = 1;
            this.buttonXoaNV.Text = "Xóa Nhân Viên";
            this.buttonXoaNV.UseVisualStyleBackColor = true;
            this.buttonXoaNV.Click += new System.EventHandler(this.buttonXoaNV_Click);
            // 
            // ButtonThemNV
            // 
            this.ButtonThemNV.Location = new System.Drawing.Point(86, 23);
            this.ButtonThemNV.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ButtonThemNV.Name = "ButtonThemNV";
            this.ButtonThemNV.Size = new System.Drawing.Size(187, 58);
            this.ButtonThemNV.TabIndex = 0;
            this.ButtonThemNV.Text = "Thêm Nhân Viên";
            this.ButtonThemNV.UseVisualStyleBackColor = true;
            this.ButtonThemNV.Click += new System.EventHandler(this.ButtonThemNV_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.buttonChamCong);
            this.panel2.Controls.Add(this.customButton1);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(32, 73);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(311, 297);
            this.panel2.TabIndex = 4;
            // 
            // buttonChamCong
            // 
            this.buttonChamCong.Location = new System.Drawing.Point(55, 170);
            this.buttonChamCong.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonChamCong.Name = "buttonChamCong";
            this.buttonChamCong.Size = new System.Drawing.Size(182, 54);
            this.buttonChamCong.TabIndex = 8;
            this.buttonChamCong.Text = "Chấm Công";
            this.buttonChamCong.UseVisualStyleBackColor = true;
            this.buttonChamCong.Click += new System.EventHandler(this.buttonChamCong_Click);
            // 
            // customButton1
            // 
            this.customButton1.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.customButton1.Location = new System.Drawing.Point(55, 58);
            this.customButton1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.customButton1.Name = "customButton1";
            this.customButton1.Size = new System.Drawing.Size(182, 53);
            this.customButton1.TabIndex = 1;
            this.customButton1.Text = "Kho Hàng";
            this.customButton1.UseVisualStyleBackColor = true;
            this.customButton1.Click += new System.EventHandler(this.customButton1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(40, 0);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(213, 32);
            this.label3.TabIndex = 0;
            this.label3.Text = "Quản Lý Cửa Hàng";
            // 
            // btnOUT
            // 
            this.btnOUT.Location = new System.Drawing.Point(697, 36);
            this.btnOUT.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnOUT.Name = "btnOUT";
            this.btnOUT.Size = new System.Drawing.Size(90, 27);
            this.btnOUT.TabIndex = 5;
            this.btnOUT.Text = "Log Out";
            this.btnOUT.UseVisualStyleBackColor = true;
            this.btnOUT.Click += new System.EventHandler(this.btnOUT_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(382, 38);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(130, 27);
            this.dateTimePicker1.TabIndex = 6;
            // 
            // buttonThongKe
            // 
            this.buttonThongKe.Location = new System.Drawing.Point(516, 38);
            this.buttonThongKe.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonThongKe.Name = "buttonThongKe";
            this.buttonThongKe.Size = new System.Drawing.Size(67, 27);
            this.buttonThongKe.TabIndex = 7;
            this.buttonThongKe.Text = "Tìm";
            this.buttonThongKe.UseVisualStyleBackColor = true;
            this.buttonThongKe.Click += new System.EventHandler(this.buttonThongKe_Click);
            // 
            // QuanLyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(869, 516);
            this.Controls.Add(this.buttonThongKe);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.btnOUT);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridViewDoanhThu);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "QuanLyForm";
            this.Text = "QuanLyForm";
            this.Load += new System.EventHandler(this.QuanLyForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDoanhThu)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridViewDoanhThu;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonQuanLyNV;
        private System.Windows.Forms.Button buttonXoaNV;
        private System.Windows.Forms.Button ButtonThemNV;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button buttonChamCong;
        private System.Windows.Forms.Button customButton1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnOUT;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button buttonThongKe;
    }
}