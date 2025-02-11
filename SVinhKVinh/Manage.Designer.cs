namespace SVinhKVinh
{
    partial class Manage
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.adminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sửaThôngTinĐăngNhậpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngXuấtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thôngTinQuảnTrịViênToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thôngTinQuảnLýChungCưToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Location = new System.Drawing.Point(12, 52);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(264, 237);
            this.panel1.TabIndex = 4;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.White;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.textBox1.Location = new System.Drawing.Point(4, 3);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBox1.Size = new System.Drawing.Size(257, 35);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "Tầng 6- Tòa S9- Khu A";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adminToolStripMenuItem,
            this.thôngTinQuảnTrịViênToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // adminToolStripMenuItem
            // 
            this.adminToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sửaThôngTinĐăngNhậpToolStripMenuItem,
            this.đăngXuấtToolStripMenuItem});
            this.adminToolStripMenuItem.Name = "adminToolStripMenuItem";
            this.adminToolStripMenuItem.Size = new System.Drawing.Size(67, 24);
            this.adminToolStripMenuItem.Text = "Admin";
            // 
            // sửaThôngTinĐăngNhậpToolStripMenuItem
            // 
            this.sửaThôngTinĐăngNhậpToolStripMenuItem.Name = "sửaThôngTinĐăngNhậpToolStripMenuItem";
            this.sửaThôngTinĐăngNhậpToolStripMenuItem.Size = new System.Drawing.Size(256, 26);
            this.sửaThôngTinĐăngNhậpToolStripMenuItem.Text = "Sửa thông tin đăng nhập";
            this.sửaThôngTinĐăngNhậpToolStripMenuItem.Click += new System.EventHandler(this.sửaThôngTinĐăngNhậpToolStripMenuItem_Click_1);
            // 
            // đăngXuấtToolStripMenuItem
            // 
            this.đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            this.đăngXuấtToolStripMenuItem.Size = new System.Drawing.Size(256, 26);
            this.đăngXuấtToolStripMenuItem.Text = "Đăng xuất";
            this.đăngXuấtToolStripMenuItem.Click += new System.EventHandler(this.đăngXuấtToolStripMenuItem_Click_1);
            // 
            // thôngTinQuảnTrịViênToolStripMenuItem
            // 
            this.thôngTinQuảnTrịViênToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thôngTinQuảnLýChungCưToolStripMenuItem});
            this.thôngTinQuảnTrịViênToolStripMenuItem.Name = "thôngTinQuảnTrịViênToolStripMenuItem";
            this.thôngTinQuảnTrịViênToolStripMenuItem.Size = new System.Drawing.Size(172, 24);
            this.thôngTinQuảnTrịViênToolStripMenuItem.Text = "Thông tin quản trị viên";
            // 
            // thôngTinQuảnLýChungCưToolStripMenuItem
            // 
            this.thôngTinQuảnLýChungCưToolStripMenuItem.Name = "thôngTinQuảnLýChungCưToolStripMenuItem";
            this.thôngTinQuảnLýChungCưToolStripMenuItem.Size = new System.Drawing.Size(271, 26);
            this.thôngTinQuảnLýChungCưToolStripMenuItem.Text = "Thông tin quản lý chung cư";
            this.thôngTinQuảnLýChungCưToolStripMenuItem.Click += new System.EventHandler(this.thôngTinQuảnLýChungCưToolStripMenuItem_Click);
            // 
            // Manage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 690);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Manage";
            this.Text = "PHẦN MỀM QUẢN LÝ ĐIỆN/NƯỚC CHUNG CƯ MINI";
            this.Load += new System.EventHandler(this.Manage_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem adminToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sửaThôngTinĐăngNhậpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đăngXuấtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thôngTinQuảnTrịViênToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thôngTinQuảnLýChungCưToolStripMenuItem;
    }
}