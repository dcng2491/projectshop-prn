namespace QuanLyBanHangFinal
{
    partial class MenuForm
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
            this.mặtHàngToolStripMenuItem = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.kháchHàngToolStripMenuItem = new System.Windows.Forms.Button();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.buttonThoat = new System.Windows.Forms.Button();
            this.buttonDangXuat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // mặtHàngToolStripMenuItem
            // 
            this.mặtHàngToolStripMenuItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mặtHàngToolStripMenuItem.Location = new System.Drawing.Point(35, 5);
            this.mặtHàngToolStripMenuItem.Name = "mặtHàngToolStripMenuItem";
            this.mặtHàngToolStripMenuItem.Size = new System.Drawing.Size(112, 34);
            this.mặtHàngToolStripMenuItem.TabIndex = 0;
            this.mặtHàngToolStripMenuItem.Text = "Sản Phẩm";
            this.mặtHàngToolStripMenuItem.UseVisualStyleBackColor = true;
            this.mặtHàngToolStripMenuItem.Click += new System.EventHandler(this.mặtHàngToolStripMenuItem_Click_1);
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(300, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(128, 34);
            this.button2.TabIndex = 1;
            this.button2.Text = "Khách Hàng";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // kháchHàngToolStripMenuItem
            // 
            this.kháchHàngToolStripMenuItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.kháchHàngToolStripMenuItem.Location = new System.Drawing.Point(171, 5);
            this.kháchHàngToolStripMenuItem.Name = "kháchHàngToolStripMenuItem";
            this.kháchHàngToolStripMenuItem.Size = new System.Drawing.Size(112, 34);
            this.kháchHàngToolStripMenuItem.TabIndex = 2;
            this.kháchHàngToolStripMenuItem.Text = "Hóa Đơn";
            this.kháchHàngToolStripMenuItem.UseVisualStyleBackColor = true;
            this.kháchHàngToolStripMenuItem.Click += new System.EventHandler(this.kháchHàngToolStripMenuItem_Click_1);
            // 
            // panelMenu
            // 
            this.panelMenu.Location = new System.Drawing.Point(35, 58);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(1181, 742);
            this.panelMenu.TabIndex = 3;
            this.panelMenu.Paint += new System.Windows.Forms.PaintEventHandler(this.panelMenu_Paint_1);
            // 
            // buttonThoat
            // 
            this.buttonThoat.Location = new System.Drawing.Point(608, 12);
            this.buttonThoat.Name = "buttonThoat";
            this.buttonThoat.Size = new System.Drawing.Size(112, 34);
            this.buttonThoat.TabIndex = 4;
            this.buttonThoat.Text = "Exit";
            this.buttonThoat.UseVisualStyleBackColor = true;
            this.buttonThoat.Click += new System.EventHandler(this.buttonThoat_Click_2);
            // 
            // buttonDangXuat
            // 
            this.buttonDangXuat.Location = new System.Drawing.Point(755, 12);
            this.buttonDangXuat.Name = "buttonDangXuat";
            this.buttonDangXuat.Size = new System.Drawing.Size(112, 34);
            this.buttonDangXuat.TabIndex = 5;
            this.buttonDangXuat.Text = "Log Out";
            this.buttonDangXuat.UseVisualStyleBackColor = true;
            this.buttonDangXuat.Click += new System.EventHandler(this.buttonDangXuat_Click_1);
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1233, 810);
            this.Controls.Add(this.buttonDangXuat);
            this.Controls.Add(this.buttonThoat);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.kháchHàngToolStripMenuItem);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.mặtHàngToolStripMenuItem);
            this.Name = "MenuForm";
            this.Text = "MenuForm";
            this.Load += new System.EventHandler(this.MenuForm_Load_1);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button mặtHàngToolStripMenuItem;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button kháchHàngToolStripMenuItem;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button buttonThoat;
        private System.Windows.Forms.Button buttonDangXuat;
    }
}