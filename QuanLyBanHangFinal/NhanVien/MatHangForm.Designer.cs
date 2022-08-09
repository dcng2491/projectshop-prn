namespace QuanLyBanHangFinal.NhanVien
{
    partial class MatHangForm
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
            this.labelNhanVien = new System.Windows.Forms.Label();
            this.pictureBoxNhanVien = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.buttonSua = new System.Windows.Forms.Button();
            this.buttonReset = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.comboBoxLoaiHang = new System.Windows.Forms.TextBox();
            this.pictureBoxHinh = new System.Windows.Forms.PictureBox();
            this.buttonXoa = new System.Windows.Forms.Button();
            this.buttonNhap = new System.Windows.Forms.Button();
            this.textBoxSL = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxGia = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonUpload = new System.Windows.Forms.Button();
            this.textBoxTenMH = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxMaHang = new System.Windows.Forms.TextBox();
            this.buttonTimKiem = new System.Windows.Forms.Button();
            this.textBoxTimKiem = new System.Windows.Forms.TextBox();
            this.radioButtonTenMH = new System.Windows.Forms.RadioButton();
            this.radioButtonMaMH = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelThongTinKho = new System.Windows.Forms.Label();
            this.dataGridViewMatHang = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNhanVien)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHinh)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMatHang)).BeginInit();
            this.SuspendLayout();
            // 
            // labelNhanVien
            // 
            this.labelNhanVien.AutoSize = true;
            this.labelNhanVien.Location = new System.Drawing.Point(16, 12);
            this.labelNhanVien.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelNhanVien.Name = "labelNhanVien";
            this.labelNhanVien.Size = new System.Drawing.Size(93, 25);
            this.labelNhanVien.TabIndex = 1;
            this.labelNhanVien.Text = "Nhân Viên";
            // 
            // pictureBoxNhanVien
            // 
            this.pictureBoxNhanVien.Location = new System.Drawing.Point(115, 0);
            this.pictureBoxNhanVien.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBoxNhanVien.Name = "pictureBoxNhanVien";
            this.pictureBoxNhanVien.Size = new System.Drawing.Size(192, 162);
            this.pictureBoxNhanVien.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxNhanVien.TabIndex = 0;
            this.pictureBoxNhanVien.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.labelNhanVien);
            this.panel3.Controls.Add(this.pictureBoxNhanVien);
            this.panel3.Location = new System.Drawing.Point(864, 561);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(311, 165);
            this.panel3.TabIndex = 7;
            // 
            // buttonSua
            // 
            this.buttonSua.BackColor = System.Drawing.Color.Red;
            this.buttonSua.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonSua.Location = new System.Drawing.Point(18, 474);
            this.buttonSua.Margin = new System.Windows.Forms.Padding(2);
            this.buttonSua.Name = "buttonSua";
            this.buttonSua.Size = new System.Drawing.Size(112, 34);
            this.buttonSua.TabIndex = 7;
            this.buttonSua.Text = "Chỉnh Sửa";
            this.buttonSua.UseVisualStyleBackColor = false;
            this.buttonSua.Click += new System.EventHandler(this.buttonSua_Click);
            // 
            // buttonReset
            // 
            this.buttonReset.BackColor = System.Drawing.Color.Red;
            this.buttonReset.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonReset.Location = new System.Drawing.Point(181, 474);
            this.buttonReset.Margin = new System.Windows.Forms.Padding(2);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(112, 34);
            this.buttonReset.TabIndex = 6;
            this.buttonReset.Text = "Reset";
            this.buttonReset.UseVisualStyleBackColor = false;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 158);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Hình ảnh";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 68);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Loại Hàng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Hàng";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.comboBoxLoaiHang);
            this.panel2.Controls.Add(this.pictureBoxHinh);
            this.panel2.Controls.Add(this.buttonXoa);
            this.panel2.Controls.Add(this.buttonNhap);
            this.panel2.Controls.Add(this.textBoxSL);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.textBoxGia);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.buttonUpload);
            this.panel2.Controls.Add(this.textBoxTenMH);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.textBoxMaHang);
            this.panel2.Controls.Add(this.buttonSua);
            this.panel2.Controls.Add(this.buttonReset);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(864, 21);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(311, 530);
            this.panel2.TabIndex = 6;
            // 
            // comboBoxLoaiHang
            // 
            this.comboBoxLoaiHang.Location = new System.Drawing.Point(109, 65);
            this.comboBoxLoaiHang.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxLoaiHang.Name = "comboBoxLoaiHang";
            this.comboBoxLoaiHang.Size = new System.Drawing.Size(184, 31);
            this.comboBoxLoaiHang.TabIndex = 5;
            // 
            // pictureBoxHinh
            // 
            this.pictureBoxHinh.Location = new System.Drawing.Point(115, 158);
            this.pictureBoxHinh.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBoxHinh.Name = "pictureBoxHinh";
            this.pictureBoxHinh.Size = new System.Drawing.Size(178, 169);
            this.pictureBoxHinh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxHinh.TabIndex = 26;
            this.pictureBoxHinh.TabStop = false;
            // 
            // buttonXoa
            // 
            this.buttonXoa.BackColor = System.Drawing.Color.Red;
            this.buttonXoa.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonXoa.Location = new System.Drawing.Point(181, 434);
            this.buttonXoa.Margin = new System.Windows.Forms.Padding(2);
            this.buttonXoa.Name = "buttonXoa";
            this.buttonXoa.Size = new System.Drawing.Size(112, 34);
            this.buttonXoa.TabIndex = 25;
            this.buttonXoa.Text = "Hủy Hàng";
            this.buttonXoa.UseVisualStyleBackColor = false;
            this.buttonXoa.Click += new System.EventHandler(this.buttonXoa_Click);
            // 
            // buttonNhap
            // 
            this.buttonNhap.BackColor = System.Drawing.Color.Red;
            this.buttonNhap.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonNhap.Location = new System.Drawing.Point(18, 434);
            this.buttonNhap.Margin = new System.Windows.Forms.Padding(2);
            this.buttonNhap.Name = "buttonNhap";
            this.buttonNhap.Size = new System.Drawing.Size(112, 34);
            this.buttonNhap.TabIndex = 24;
            this.buttonNhap.Text = "Nhập Kho";
            this.buttonNhap.UseVisualStyleBackColor = false;
            this.buttonNhap.Click += new System.EventHandler(this.buttonNhap_Click);
            // 
            // textBoxSL
            // 
            this.textBoxSL.Location = new System.Drawing.Point(109, 380);
            this.textBoxSL.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxSL.Name = "textBoxSL";
            this.textBoxSL.Size = new System.Drawing.Size(184, 31);
            this.textBoxSL.TabIndex = 23;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 380);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 25);
            this.label5.TabIndex = 22;
            this.label5.Text = "Số Lượng";
            // 
            // textBoxGia
            // 
            this.textBoxGia.Location = new System.Drawing.Point(109, 332);
            this.textBoxGia.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxGia.Name = "textBoxGia";
            this.textBoxGia.Size = new System.Drawing.Size(184, 31);
            this.textBoxGia.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 332);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 25);
            this.label2.TabIndex = 20;
            this.label2.Text = "Giá SP";
            // 
            // buttonUpload
            // 
            this.buttonUpload.BackColor = System.Drawing.Color.Red;
            this.buttonUpload.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonUpload.Location = new System.Drawing.Point(8, 185);
            this.buttonUpload.Margin = new System.Windows.Forms.Padding(2);
            this.buttonUpload.Name = "buttonUpload";
            this.buttonUpload.Size = new System.Drawing.Size(102, 34);
            this.buttonUpload.TabIndex = 18;
            this.buttonUpload.Text = "Upload";
            this.buttonUpload.UseVisualStyleBackColor = false;
            this.buttonUpload.Click += new System.EventHandler(this.buttonUpload_Click);
            // 
            // textBoxTenMH
            // 
            this.textBoxTenMH.Location = new System.Drawing.Point(111, 108);
            this.textBoxTenMH.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxTenMH.Name = "textBoxTenMH";
            this.textBoxTenMH.Size = new System.Drawing.Size(184, 31);
            this.textBoxTenMH.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 108);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 25);
            this.label6.TabIndex = 16;
            this.label6.Text = "Tên Hàng";
            // 
            // textBoxMaHang
            // 
            this.textBoxMaHang.Location = new System.Drawing.Point(111, 22);
            this.textBoxMaHang.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxMaHang.Name = "textBoxMaHang";
            this.textBoxMaHang.Size = new System.Drawing.Size(184, 31);
            this.textBoxMaHang.TabIndex = 9;
            // 
            // buttonTimKiem
            // 
            this.buttonTimKiem.Location = new System.Drawing.Point(664, 59);
            this.buttonTimKiem.Margin = new System.Windows.Forms.Padding(2);
            this.buttonTimKiem.Name = "buttonTimKiem";
            this.buttonTimKiem.Size = new System.Drawing.Size(112, 34);
            this.buttonTimKiem.TabIndex = 3;
            this.buttonTimKiem.Text = "Tìm Kiếm";
            this.buttonTimKiem.UseVisualStyleBackColor = true;
            this.buttonTimKiem.Click += new System.EventHandler(this.buttonTimKiem_Click);
            // 
            // textBoxTimKiem
            // 
            this.textBoxTimKiem.Location = new System.Drawing.Point(348, 62);
            this.textBoxTimKiem.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxTimKiem.Name = "textBoxTimKiem";
            this.textBoxTimKiem.Size = new System.Drawing.Size(295, 31);
            this.textBoxTimKiem.TabIndex = 2;
            // 
            // radioButtonTenMH
            // 
            this.radioButtonTenMH.AutoSize = true;
            this.radioButtonTenMH.Location = new System.Drawing.Point(598, 2);
            this.radioButtonTenMH.Margin = new System.Windows.Forms.Padding(2);
            this.radioButtonTenMH.Name = "radioButtonTenMH";
            this.radioButtonTenMH.Size = new System.Drawing.Size(147, 29);
            this.radioButtonTenMH.TabIndex = 1;
            this.radioButtonTenMH.TabStop = true;
            this.radioButtonTenMH.Text = "Tên Mặt Hàng";
            this.radioButtonTenMH.UseVisualStyleBackColor = true;
            // 
            // radioButtonMaMH
            // 
            this.radioButtonMaMH.AutoSize = true;
            this.radioButtonMaMH.Location = new System.Drawing.Point(402, 2);
            this.radioButtonMaMH.Margin = new System.Windows.Forms.Padding(2);
            this.radioButtonMaMH.Name = "radioButtonMaMH";
            this.radioButtonMaMH.Size = new System.Drawing.Size(146, 29);
            this.radioButtonMaMH.TabIndex = 0;
            this.radioButtonMaMH.TabStop = true;
            this.radioButtonMaMH.Text = "Mã Mặt Hàng";
            this.radioButtonMaMH.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.labelThongTinKho);
            this.panel1.Controls.Add(this.buttonTimKiem);
            this.panel1.Controls.Add(this.textBoxTimKiem);
            this.panel1.Controls.Add(this.radioButtonTenMH);
            this.panel1.Controls.Add(this.radioButtonMaMH);
            this.panel1.Location = new System.Drawing.Point(16, 21);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(842, 118);
            this.panel1.TabIndex = 4;
            // 
            // labelThongTinKho
            // 
            this.labelThongTinKho.AutoSize = true;
            this.labelThongTinKho.Location = new System.Drawing.Point(24, 11);
            this.labelThongTinKho.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelThongTinKho.Name = "labelThongTinKho";
            this.labelThongTinKho.Size = new System.Drawing.Size(0, 25);
            this.labelThongTinKho.TabIndex = 4;
            // 
            // dataGridViewMatHang
            // 
            this.dataGridViewMatHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMatHang.Location = new System.Drawing.Point(16, 144);
            this.dataGridViewMatHang.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewMatHang.Name = "dataGridViewMatHang";
            this.dataGridViewMatHang.RowHeadersWidth = 62;
            this.dataGridViewMatHang.RowTemplate.Height = 33;
            this.dataGridViewMatHang.Size = new System.Drawing.Size(842, 582);
            this.dataGridViewMatHang.TabIndex = 5;
            this.dataGridViewMatHang.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewMatHang_CellClick);
            // 
            // MatHangForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridViewMatHang);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MatHangForm";
            this.Size = new System.Drawing.Size(1181, 742);
            this.Load += new System.EventHandler(this.MatHangForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNhanVien)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHinh)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMatHang)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label labelNhanVien;
        private System.Windows.Forms.PictureBox pictureBoxNhanVien;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button buttonSua;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button buttonTimKiem;
        private System.Windows.Forms.TextBox textBoxTimKiem;
        private System.Windows.Forms.RadioButton radioButtonTenMH;
        private System.Windows.Forms.RadioButton radioButtonMaMH;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridViewMatHang;
        private System.Windows.Forms.Button buttonXoa;
        private System.Windows.Forms.Button buttonNhap;
        private System.Windows.Forms.TextBox textBoxSL;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxGia;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonUpload;
        private System.Windows.Forms.TextBox textBoxTenMH;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labelThongTinKho;
        private System.Windows.Forms.PictureBox pictureBoxHinh;
        private System.Windows.Forms.TextBox comboBoxLoaiHang;
        private System.Windows.Forms.TextBox textBoxMaHang;
    }
}
