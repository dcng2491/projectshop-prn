namespace QuanLyBanHangFinal.Admin
{
    partial class KhoHangForm
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.radioButtonMaMH = new System.Windows.Forms.RadioButton();
            this.radioButtonTenMH = new System.Windows.Forms.RadioButton();
            this.textBoxTimKiem = new System.Windows.Forms.TextBox();
            this.buttonTimKiem = new System.Windows.Forms.Button();
            this.dataGridViewKhoHang = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKhoHang)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonTimKiem);
            this.panel1.Controls.Add(this.textBoxTimKiem);
            this.panel1.Controls.Add(this.radioButtonTenMH);
            this.panel1.Controls.Add(this.radioButtonMaMH);
            this.panel1.Location = new System.Drawing.Point(-1, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1168, 87);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(-1, 604);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1168, 96);
            this.panel3.TabIndex = 1;
            // 
            // radioButtonMaMH
            // 
            this.radioButtonMaMH.AutoSize = true;
            this.radioButtonMaMH.Location = new System.Drawing.Point(403, 5);
            this.radioButtonMaMH.Name = "radioButtonMaMH";
            this.radioButtonMaMH.Size = new System.Drawing.Size(146, 29);
            this.radioButtonMaMH.TabIndex = 0;
            this.radioButtonMaMH.TabStop = true;
            this.radioButtonMaMH.Text = "Mã Sản Phẩm";
            this.radioButtonMaMH.UseVisualStyleBackColor = true;
            // 
            // radioButtonTenMH
            // 
            this.radioButtonTenMH.AutoSize = true;
            this.radioButtonTenMH.Location = new System.Drawing.Point(630, 5);
            this.radioButtonTenMH.Name = "radioButtonTenMH";
            this.radioButtonTenMH.Size = new System.Drawing.Size(147, 29);
            this.radioButtonTenMH.TabIndex = 1;
            this.radioButtonTenMH.TabStop = true;
            this.radioButtonTenMH.Text = "Tên Sản Phẩm";
            this.radioButtonTenMH.UseVisualStyleBackColor = true;
            // 
            // textBoxTimKiem
            // 
            this.textBoxTimKiem.Location = new System.Drawing.Point(478, 40);
            this.textBoxTimKiem.Name = "textBoxTimKiem";
            this.textBoxTimKiem.Size = new System.Drawing.Size(236, 31);
            this.textBoxTimKiem.TabIndex = 2;
            // 
            // buttonTimKiem
            // 
            this.buttonTimKiem.Location = new System.Drawing.Point(739, 40);
            this.buttonTimKiem.Name = "buttonTimKiem";
            this.buttonTimKiem.Size = new System.Drawing.Size(112, 34);
            this.buttonTimKiem.TabIndex = 3;
            this.buttonTimKiem.Text = "Tìm";
            this.buttonTimKiem.UseVisualStyleBackColor = true;
            this.buttonTimKiem.Click += new System.EventHandler(this.buttonTimKiem_Click);
            // 
            // dataGridViewKhoHang
            // 
            this.dataGridViewKhoHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewKhoHang.Location = new System.Drawing.Point(-1, 96);
            this.dataGridViewKhoHang.Name = "dataGridViewKhoHang";
            this.dataGridViewKhoHang.RowHeadersWidth = 62;
            this.dataGridViewKhoHang.RowTemplate.Height = 33;
            this.dataGridViewKhoHang.Size = new System.Drawing.Size(1168, 502);
            this.dataGridViewKhoHang.TabIndex = 2;
            // 
            // KhoHangForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1169, 703);
            this.Controls.Add(this.dataGridViewKhoHang);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Name = "KhoHangForm";
            this.Text = "KhoHangForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKhoHang)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonTimKiem;
        private System.Windows.Forms.TextBox textBoxTimKiem;
        private System.Windows.Forms.RadioButton radioButtonTenMH;
        private System.Windows.Forms.RadioButton radioButtonMaMH;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dataGridViewKhoHang;
    }
}