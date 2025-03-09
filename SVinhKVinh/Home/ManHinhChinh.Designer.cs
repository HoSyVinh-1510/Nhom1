namespace SVinhKVinh.Home
{
    partial class ManHinhChinh
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManHinhChinh));
            this.adminstatorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thôngTinĐăngNhậpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sửaThôngTinĐăngNhậpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thoátỨngDụngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.trợGiúpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // adminstatorToolStripMenuItem
            // 
            this.adminstatorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thôngTinĐăngNhậpToolStripMenuItem,
            this.sửaThôngTinĐăngNhậpToolStripMenuItem,
            this.thoátỨngDụngToolStripMenuItem});
            this.adminstatorToolStripMenuItem.Name = "adminstatorToolStripMenuItem";
            resources.ApplyResources(this.adminstatorToolStripMenuItem, "adminstatorToolStripMenuItem");
            this.adminstatorToolStripMenuItem.Tag = "Lựa chọn thông tin về tài khoản đăng nhập";
            this.adminstatorToolStripMenuItem.Click += new System.EventHandler(this.adminstatorToolStripMenuItem_Click);
            // 
            // thôngTinĐăngNhậpToolStripMenuItem
            // 
            this.thôngTinĐăngNhậpToolStripMenuItem.Name = "thôngTinĐăngNhậpToolStripMenuItem";
            resources.ApplyResources(this.thôngTinĐăngNhậpToolStripMenuItem, "thôngTinĐăngNhậpToolStripMenuItem");
            this.thôngTinĐăngNhậpToolStripMenuItem.Click += new System.EventHandler(this.thôngTinĐăngNhậpToolStripMenuItem_Click);
            // 
            // sửaThôngTinĐăngNhậpToolStripMenuItem
            // 
            this.sửaThôngTinĐăngNhậpToolStripMenuItem.Name = "sửaThôngTinĐăngNhậpToolStripMenuItem";
            resources.ApplyResources(this.sửaThôngTinĐăngNhậpToolStripMenuItem, "sửaThôngTinĐăngNhậpToolStripMenuItem");
            this.sửaThôngTinĐăngNhậpToolStripMenuItem.Click += new System.EventHandler(this.sửaThôngTinĐăngNhậpToolStripMenuItem_Click);
            // 
            // thoátỨngDụngToolStripMenuItem
            // 
            this.thoátỨngDụngToolStripMenuItem.Name = "thoátỨngDụngToolStripMenuItem";
            resources.ApplyResources(this.thoátỨngDụngToolStripMenuItem, "thoátỨngDụngToolStripMenuItem");
            this.thoátỨngDụngToolStripMenuItem.Click += new System.EventHandler(this.thoátỨngDụngToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adminstatorToolStripMenuItem,
            this.trợGiúpToolStripMenuItem});
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.Name = "menuStrip1";
            // 
            // trợGiúpToolStripMenuItem
            // 
            this.trợGiúpToolStripMenuItem.Name = "trợGiúpToolStripMenuItem";
            resources.ApplyResources(this.trợGiúpToolStripMenuItem, "trợGiúpToolStripMenuItem");
            // 
            // ManHinhChinh
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ManHinhChinh";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ManHinChinh_FormClosed);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem adminstatorToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem trợGiúpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thôngTinĐăngNhậpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sửaThôngTinĐăngNhậpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thoátỨngDụngToolStripMenuItem;
    }
}