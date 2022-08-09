namespace QuanLyBanHangFinal.NhanVien
{
    partial class CheckmaAdminForm
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
            this.textBoxCustom1 = new System.Windows.Forms.TextBox();
            this.customButton2 = new System.Windows.Forms.Button();
            this.customButton1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(109, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Xác Nhận";
            // 
            // textBoxCustom1
            // 
            this.textBoxCustom1.Location = new System.Drawing.Point(76, 71);
            this.textBoxCustom1.Name = "textBoxCustom1";
            this.textBoxCustom1.Size = new System.Drawing.Size(190, 31);
            this.textBoxCustom1.TabIndex = 1;
            // 
            // customButton2
            // 
            this.customButton2.Location = new System.Drawing.Point(46, 176);
            this.customButton2.Name = "customButton2";
            this.customButton2.Size = new System.Drawing.Size(112, 34);
            this.customButton2.TabIndex = 2;
            this.customButton2.Text = "Thoát";
            this.customButton2.UseVisualStyleBackColor = true;
            this.customButton2.Click += new System.EventHandler(this.customButton2_Click);
            // 
            // customButton1
            // 
            this.customButton1.Location = new System.Drawing.Point(186, 176);
            this.customButton1.Name = "customButton1";
            this.customButton1.Size = new System.Drawing.Size(112, 34);
            this.customButton1.TabIndex = 3;
            this.customButton1.Text = "Xác Nhận";
            this.customButton1.UseVisualStyleBackColor = true;
            this.customButton1.Click += new System.EventHandler(this.customButton1_Click);
            // 
            // CheckmaAdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(347, 290);
            this.Controls.Add(this.customButton1);
            this.Controls.Add(this.customButton2);
            this.Controls.Add(this.textBoxCustom1);
            this.Controls.Add(this.label1);
            this.Name = "CheckmaAdminForm";
            this.Text = "CheckmaAdminForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxCustom1;
        private System.Windows.Forms.Button customButton2;
        private System.Windows.Forms.Button customButton1;
    }
}