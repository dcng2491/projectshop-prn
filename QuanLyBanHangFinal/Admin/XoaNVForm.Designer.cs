namespace QuanLyBanHangFinal.Admin
{
    partial class XoaNVForm
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
            this.textBoxXoaNV = new System.Windows.Forms.TextBox();
            this.buttonXoaNV = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(130, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Nhân Viên";
            // 
            // textBoxXoaNV
            // 
            this.textBoxXoaNV.Location = new System.Drawing.Point(90, 117);
            this.textBoxXoaNV.Name = "textBoxXoaNV";
            this.textBoxXoaNV.Size = new System.Drawing.Size(150, 31);
            this.textBoxXoaNV.TabIndex = 1;
            // 
            // buttonXoaNV
            // 
            this.buttonXoaNV.Location = new System.Drawing.Point(255, 117);
            this.buttonXoaNV.Name = "buttonXoaNV";
            this.buttonXoaNV.Size = new System.Drawing.Size(112, 34);
            this.buttonXoaNV.TabIndex = 2;
            this.buttonXoaNV.Text = "Xóa";
            this.buttonXoaNV.UseVisualStyleBackColor = true;
            this.buttonXoaNV.Click += new System.EventHandler(this.buttonXoaNV_Click);
            // 
            // XoaNVForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 272);
            this.Controls.Add(this.buttonXoaNV);
            this.Controls.Add(this.textBoxXoaNV);
            this.Controls.Add(this.label1);
            this.Name = "XoaNVForm";
            this.Text = "XoaNVForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxXoaNV;
        private System.Windows.Forms.Button buttonXoaNV;
    }
}