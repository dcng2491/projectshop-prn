namespace QuanLyBanHangFinal.MuaHang
{
    partial class ThanhToanForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.labelTenKH = new System.Windows.Forms.Label();
            this.labelMaKH = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonThanhToan = new System.Windows.Forms.Button();
            this.labelTongTien = new System.Windows.Forms.Label();
            this.dataGridViewTT = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTT)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.labelTenKH);
            this.panel1.Controls.Add(this.labelMaKH);
            this.panel1.Location = new System.Drawing.Point(18, 10);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(413, 74);
            this.panel1.TabIndex = 3;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Thông Tin Hóa Đơn";
            // 
            // labelTenKH
            // 
            this.labelTenKH.AutoSize = true;
            this.labelTenKH.Location = new System.Drawing.Point(158, 45);
            this.labelTenKH.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTenKH.Name = "labelTenKH";
            this.labelTenKH.Size = new System.Drawing.Size(116, 20);
            this.labelTenKH.TabIndex = 1;
            this.labelTenKH.Text = "Tên Khách Hàng";
            // 
            // labelMaKH
            // 
            this.labelMaKH.AutoSize = true;
            this.labelMaKH.Location = new System.Drawing.Point(158, 16);
            this.labelMaKH.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelMaKH.Name = "labelMaKH";
            this.labelMaKH.Size = new System.Drawing.Size(114, 20);
            this.labelMaKH.TabIndex = 0;
            this.labelMaKH.Text = "MS Khách Hàng";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.buttonThanhToan);
            this.panel2.Controls.Add(this.labelTongTien);
            this.panel2.Location = new System.Drawing.Point(10, 438);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(413, 75);
            this.panel2.TabIndex = 4;
            // 
            // buttonThanhToan
            // 
            this.buttonThanhToan.BackColor = System.Drawing.Color.White;
            this.buttonThanhToan.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonThanhToan.Location = new System.Drawing.Point(217, 42);
            this.buttonThanhToan.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonThanhToan.Name = "buttonThanhToan";
            this.buttonThanhToan.Size = new System.Drawing.Size(124, 27);
            this.buttonThanhToan.TabIndex = 1;
            this.buttonThanhToan.Text = "Xác Nhận ";
            this.buttonThanhToan.UseVisualStyleBackColor = false;
            this.buttonThanhToan.Click += new System.EventHandler(this.buttonThanhToan_Click_1);
            // 
            // labelTongTien
            // 
            this.labelTongTien.AutoSize = true;
            this.labelTongTien.BackColor = System.Drawing.Color.White;
            this.labelTongTien.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelTongTien.ForeColor = System.Drawing.Color.Black;
            this.labelTongTien.Location = new System.Drawing.Point(12, 7);
            this.labelTongTien.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTongTien.Name = "labelTongTien";
            this.labelTongTien.Size = new System.Drawing.Size(152, 37);
            this.labelTongTien.TabIndex = 0;
            this.labelTongTien.Text = "Tổng Tiền:";
            // 
            // dataGridViewTT
            // 
            this.dataGridViewTT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTT.Location = new System.Drawing.Point(18, 89);
            this.dataGridViewTT.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridViewTT.Name = "dataGridViewTT";
            this.dataGridViewTT.RowHeadersWidth = 62;
            this.dataGridViewTT.RowTemplate.Height = 33;
            this.dataGridViewTT.Size = new System.Drawing.Size(413, 345);
            this.dataGridViewTT.TabIndex = 5;
            // 
            // ThanhToanForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 523);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dataGridViewTT);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ThanhToanForm";
            this.Text = "ThanhToanForm";
            this.Load += new System.EventHandler(this.ThanhToanForm_Load_1);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTT)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelTenKH;
        private System.Windows.Forms.Label labelMaKH;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button buttonThanhToan;
        private System.Windows.Forms.Label labelTongTien;
        private System.Windows.Forms.DataGridView dataGridViewTT;
    }
}