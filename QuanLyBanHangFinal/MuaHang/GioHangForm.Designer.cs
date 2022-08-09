namespace QuanLyBanHangFinal.MuaHang
{
    partial class GioHangForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBoxTenKH = new System.Windows.Forms.TextBox();
            this.textBoxMSKH = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonThanhToan = new System.Windows.Forms.Button();
            this.buttonXoaHang = new System.Windows.Forms.Button();
            this.labelTongTien = new System.Windows.Forms.Label();
            this.dataGridViewGH = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGH)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.textBoxTenKH);
            this.panel1.Controls.Add(this.textBoxMSKH);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(720, 92);
            this.panel1.TabIndex = 0;
            // 
            // textBoxTenKH
            // 
            this.textBoxTenKH.Location = new System.Drawing.Point(341, 52);
            this.textBoxTenKH.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxTenKH.Name = "textBoxTenKH";
            this.textBoxTenKH.ReadOnly = true;
            this.textBoxTenKH.Size = new System.Drawing.Size(194, 31);
            this.textBoxTenKH.TabIndex = 3;
            // 
            // textBoxMSKH
            // 
            this.textBoxMSKH.Location = new System.Drawing.Point(341, 2);
            this.textBoxMSKH.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxMSKH.Name = "textBoxMSKH";
            this.textBoxMSKH.ReadOnly = true;
            this.textBoxMSKH.Size = new System.Drawing.Size(85, 31);
            this.textBoxMSKH.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(198, 56);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên Khách Hàng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(198, 2);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "MS Khách Hàng";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.buttonThanhToan);
            this.panel2.Controls.Add(this.buttonXoaHang);
            this.panel2.Controls.Add(this.labelTongTien);
            this.panel2.Location = new System.Drawing.Point(12, 466);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(720, 92);
            this.panel2.TabIndex = 1;
            // 
            // buttonThanhToan
            // 
            this.buttonThanhToan.BackColor = System.Drawing.Color.Red;
            this.buttonThanhToan.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonThanhToan.Location = new System.Drawing.Point(516, 52);
            this.buttonThanhToan.Margin = new System.Windows.Forms.Padding(2);
            this.buttonThanhToan.Name = "buttonThanhToan";
            this.buttonThanhToan.Size = new System.Drawing.Size(168, 34);
            this.buttonThanhToan.TabIndex = 2;
            this.buttonThanhToan.Text = "Thanh Toán";
            this.buttonThanhToan.UseVisualStyleBackColor = false;
            this.buttonThanhToan.Click += new System.EventHandler(this.buttonThanhToan_Click_1);
            // 
            // buttonXoaHang
            // 
            this.buttonXoaHang.BackColor = System.Drawing.Color.Red;
            this.buttonXoaHang.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonXoaHang.Location = new System.Drawing.Point(271, 52);
            this.buttonXoaHang.Margin = new System.Windows.Forms.Padding(2);
            this.buttonXoaHang.Name = "buttonXoaHang";
            this.buttonXoaHang.Size = new System.Drawing.Size(155, 34);
            this.buttonXoaHang.TabIndex = 1;
            this.buttonXoaHang.Text = "Xóa Hàng";
            this.buttonXoaHang.UseVisualStyleBackColor = false;
            this.buttonXoaHang.Click += new System.EventHandler(this.buttonXoaHang_Click_1);
            // 
            // labelTongTien
            // 
            this.labelTongTien.AutoSize = true;
            this.labelTongTien.BackColor = System.Drawing.Color.White;
            this.labelTongTien.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelTongTien.ForeColor = System.Drawing.Color.Black;
            this.labelTongTien.Location = new System.Drawing.Point(15, 9);
            this.labelTongTien.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTongTien.Name = "labelTongTien";
            this.labelTongTien.Size = new System.Drawing.Size(180, 45);
            this.labelTongTien.TabIndex = 0;
            this.labelTongTien.Text = "Tổng Tiền:";
            // 
            // dataGridViewGH
            // 
            this.dataGridViewGH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewGH.Location = new System.Drawing.Point(12, 111);
            this.dataGridViewGH.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewGH.Name = "dataGridViewGH";
            this.dataGridViewGH.RowHeadersWidth = 62;
            this.dataGridViewGH.RowTemplate.Height = 33;
            this.dataGridViewGH.Size = new System.Drawing.Size(720, 349);
            this.dataGridViewGH.TabIndex = 2;
            // 
            // GioHangForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 571);
            this.Controls.Add(this.dataGridViewGH);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "GioHangForm";
            this.Text = "GioHangForm";
            this.Load += new System.EventHandler(this.GioHangForm_Load_1);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGH)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBoxTenKH;
        private System.Windows.Forms.TextBox textBoxMSKH;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button buttonThanhToan;
        private System.Windows.Forms.Button buttonXoaHang;
        private System.Windows.Forms.Label labelTongTien;
        private System.Windows.Forms.DataGridView dataGridViewGH;
    }
}