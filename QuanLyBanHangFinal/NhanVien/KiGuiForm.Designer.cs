namespace QuanLyBanHangFinal.NhanVien
{
    partial class KiGuiForm
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
            this.dataGridViewKiGui = new System.Windows.Forms.DataGridView();
            this.buttonMoKiGui = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKiGui)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(297, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hóa Đơn Kí Gửi";
            // 
            // dataGridViewKiGui
            // 
            this.dataGridViewKiGui.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewKiGui.Location = new System.Drawing.Point(12, 68);
            this.dataGridViewKiGui.Name = "dataGridViewKiGui";
            this.dataGridViewKiGui.RowHeadersWidth = 62;
            this.dataGridViewKiGui.RowTemplate.Height = 33;
            this.dataGridViewKiGui.Size = new System.Drawing.Size(776, 286);
            this.dataGridViewKiGui.TabIndex = 1;
            // 
            // buttonMoKiGui
            // 
            this.buttonMoKiGui.Location = new System.Drawing.Point(334, 385);
            this.buttonMoKiGui.Name = "buttonMoKiGui";
            this.buttonMoKiGui.Size = new System.Drawing.Size(112, 34);
            this.buttonMoKiGui.TabIndex = 2;
            this.buttonMoKiGui.Text = "Mở kí gửi";
            this.buttonMoKiGui.UseVisualStyleBackColor = true;
            this.buttonMoKiGui.Click += new System.EventHandler(this.buttonMoKiGui_Click);
            // 
            // KiGuiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonMoKiGui);
            this.Controls.Add(this.dataGridViewKiGui);
            this.Controls.Add(this.label1);
            this.Name = "KiGuiForm";
            this.Text = "KiGuiForm";
            this.Load += new System.EventHandler(this.KiGuiForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKiGui)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewKiGui;
        private System.Windows.Forms.Button buttonMoKiGui;
    }
}