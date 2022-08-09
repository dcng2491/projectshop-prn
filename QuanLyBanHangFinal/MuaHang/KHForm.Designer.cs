namespace QuanLyBanHangFinal.MuaHang
{
    partial class KHForm
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel3 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.labelKH = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridViewMatHang = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBoxHinh = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.numericSoLuong = new System.Windows.Forms.NumericUpDown();
            this.textBoxMaHang = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxTenHang = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxGia = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonThem = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMatHang)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHinh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericSoLuong)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.button4);
            this.panel3.Controls.Add(this.labelKH);
            this.panel3.Controls.Add(this.button1);
            this.panel3.Controls.Add(this.button2);
            this.panel3.Location = new System.Drawing.Point(792, 542);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(404, 175);
            this.panel3.TabIndex = 15;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(18, 68);
            this.button4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(118, 36);
            this.button4.TabIndex = 42;
            this.button4.Text = "Xem giỏ";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // labelKH
            // 
            this.labelKH.AutoSize = true;
            this.labelKH.Location = new System.Drawing.Point(168, 12);
            this.labelKH.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelKH.Name = "labelKH";
            this.labelKH.Size = new System.Drawing.Size(107, 25);
            this.labelKH.TabIndex = 33;
            this.labelKH.Text = "Khách Hàng";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(286, 68);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 34);
            this.button1.TabIndex = 30;
            this.button1.Text = "Log Out";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button2.Location = new System.Drawing.Point(168, 68);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(112, 34);
            this.button2.TabIndex = 31;
            this.button2.Text = "Thoát";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridViewMatHang
            // 
            this.dataGridViewMatHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMatHang.Location = new System.Drawing.Point(19, 12);
            this.dataGridViewMatHang.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewMatHang.Name = "dataGridViewMatHang";
            this.dataGridViewMatHang.RowHeadersWidth = 62;
            this.dataGridViewMatHang.RowTemplate.Height = 33;
            this.dataGridViewMatHang.Size = new System.Drawing.Size(764, 678);
            this.dataGridViewMatHang.TabIndex = 13;
            this.dataGridViewMatHang.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewMatHang_CellClick_1);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.pictureBoxHinh);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.numericSoLuong);
            this.panel2.Controls.Add(this.textBoxMaHang);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.textBoxTenHang);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.textBoxGia);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.buttonThem);
            this.panel2.Location = new System.Drawing.Point(789, 12);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(408, 524);
            this.panel2.TabIndex = 14;
            // 
            // pictureBoxHinh
            // 
            this.pictureBoxHinh.Location = new System.Drawing.Point(155, 276);
            this.pictureBoxHinh.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBoxHinh.Name = "pictureBoxHinh";
            this.pictureBoxHinh.Size = new System.Drawing.Size(168, 179);
            this.pictureBoxHinh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxHinh.TabIndex = 40;
            this.pictureBoxHinh.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 179);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 25);
            this.label6.TabIndex = 39;
            this.label6.Text = "Số Lượng";
            // 
            // numericSoLuong
            // 
            this.numericSoLuong.Location = new System.Drawing.Point(144, 179);
            this.numericSoLuong.Margin = new System.Windows.Forms.Padding(2);
            this.numericSoLuong.Name = "numericSoLuong";
            this.numericSoLuong.Size = new System.Drawing.Size(92, 31);
            this.numericSoLuong.TabIndex = 38;
            // 
            // textBoxMaHang
            // 
            this.textBoxMaHang.ForeColor = System.Drawing.Color.White;
            this.textBoxMaHang.Location = new System.Drawing.Point(144, 64);
            this.textBoxMaHang.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxMaHang.Name = "textBoxMaHang";
            this.textBoxMaHang.Size = new System.Drawing.Size(184, 31);
            this.textBoxMaHang.TabIndex = 37;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 64);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 25);
            this.label5.TabIndex = 36;
            this.label5.Text = "Mã Hàng";
            // 
            // textBoxTenHang
            // 
            this.textBoxTenHang.BackColor = System.Drawing.SystemColors.HighlightText;
            this.textBoxTenHang.ForeColor = System.Drawing.Color.White;
            this.textBoxTenHang.Location = new System.Drawing.Point(144, 120);
            this.textBoxTenHang.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxTenHang.Name = "textBoxTenHang";
            this.textBoxTenHang.Size = new System.Drawing.Size(184, 31);
            this.textBoxTenHang.TabIndex = 35;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 120);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 25);
            this.label3.TabIndex = 34;
            this.label3.Text = "Tên Hàng";
            // 
            // textBoxGia
            // 
            this.textBoxGia.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBoxGia.Enabled = false;
            this.textBoxGia.ForeColor = System.Drawing.Color.White;
            this.textBoxGia.Location = new System.Drawing.Point(144, 228);
            this.textBoxGia.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxGia.Name = "textBoxGia";
            this.textBoxGia.Size = new System.Drawing.Size(184, 31);
            this.textBoxGia.TabIndex = 33;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 228);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 25);
            this.label2.TabIndex = 32;
            this.label2.Text = "Giá/sp";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 291);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 25);
            this.label4.TabIndex = 28;
            this.label4.Text = "Hình Ảnh";
            // 
            // buttonThem
            // 
            this.buttonThem.BackColor = System.Drawing.Color.White;
            this.buttonThem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonThem.Location = new System.Drawing.Point(35, 461);
            this.buttonThem.Margin = new System.Windows.Forms.Padding(2);
            this.buttonThem.Name = "buttonThem";
            this.buttonThem.Size = new System.Drawing.Size(334, 34);
            this.buttonThem.TabIndex = 7;
            this.buttonThem.Text = "Thêm Vào Giỏ";
            this.buttonThem.UseVisualStyleBackColor = false;
            this.buttonThem.Click += new System.EventHandler(this.buttonThem_Click_1);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(19, 696);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(764, 32);
            this.panel1.TabIndex = 43;
            // 
            // KHForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1194, 731);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.dataGridViewMatHang);
            this.Controls.Add(this.panel2);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "KHForm";
            this.Load += new System.EventHandler(this.KHForm_Load_1);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMatHang)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHinh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericSoLuong)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dataGridViewMatHang;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonThem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox pictureBoxHinh;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numericSoLuong;
        private System.Windows.Forms.TextBox textBoxMaHang;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxTenHang;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxGia;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelKH;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button4;
    }
}
