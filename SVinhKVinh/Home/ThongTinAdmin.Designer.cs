namespace SVinhKVinh.Home
{
    partial class ThongTinAdmin
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
            this.labelUserName = new System.Windows.Forms.Label();
            this.labelPassword = new System.Windows.Forms.Label();
            this.TextBoxTaiKhoan1 = new System.Windows.Forms.TextBox();
            this.TextBoxMatKhau1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TextBoxPhuongThuc = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(254, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(347, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "THÔNG TIN TÀI KHOẢN ";
            // 
            // labelUserName
            // 
            this.labelUserName.AutoSize = true;
            this.labelUserName.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelUserName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelUserName.Location = new System.Drawing.Point(59, 224);
            this.labelUserName.Name = "labelUserName";
            this.labelUserName.Size = new System.Drawing.Size(134, 33);
            this.labelUserName.TabIndex = 3;
            this.labelUserName.Text = "Tài khoản:";
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelPassword.Location = new System.Drawing.Point(64, 299);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(129, 33);
            this.labelPassword.TabIndex = 4;
            this.labelPassword.Text = "Mật khẩu:";
            this.labelPassword.Click += new System.EventHandler(this.labelPassword_Click);
            // 
            // TextBoxTaiKhoan1
            // 
            this.TextBoxTaiKhoan1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.TextBoxTaiKhoan1.Location = new System.Drawing.Point(228, 221);
            this.TextBoxTaiKhoan1.Name = "TextBoxTaiKhoan1";
            this.TextBoxTaiKhoan1.ReadOnly = true;
            this.TextBoxTaiKhoan1.Size = new System.Drawing.Size(445, 39);
            this.TextBoxTaiKhoan1.TabIndex = 2;
            this.TextBoxTaiKhoan1.TextChanged += new System.EventHandler(this.TextBoxTaiKhoan1_TextChanged);
            // 
            // TextBoxMatKhau1
            // 
            this.TextBoxMatKhau1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.TextBoxMatKhau1.Location = new System.Drawing.Point(228, 299);
            this.TextBoxMatKhau1.Name = "TextBoxMatKhau1";
            this.TextBoxMatKhau1.ReadOnly = true;
            this.TextBoxMatKhau1.Size = new System.Drawing.Size(445, 39);
            this.TextBoxMatKhau1.TabIndex = 3;
            this.TextBoxMatKhau1.TextChanged += new System.EventHandler(this.TextBoxMatKhau1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(46, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 33);
            this.label2.TabIndex = 7;
            this.label2.Text = "Phương thức:";
            // 
            // TextBoxPhuongThuc
            // 
            this.TextBoxPhuongThuc.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBoxPhuongThuc.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.TextBoxPhuongThuc.HideSelection = false;
            this.TextBoxPhuongThuc.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.TextBoxPhuongThuc.Location = new System.Drawing.Point(228, 156);
            this.TextBoxPhuongThuc.Name = "TextBoxPhuongThuc";
            this.TextBoxPhuongThuc.ReadOnly = true;
            this.TextBoxPhuongThuc.Size = new System.Drawing.Size(445, 39);
            this.TextBoxPhuongThuc.TabIndex = 1;
            this.TextBoxPhuongThuc.TextChanged += new System.EventHandler(this.TextBoxPhuongThuc_TextChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button1.ForeColor = System.Drawing.Color.IndianRed;
            this.button1.Location = new System.Drawing.Point(29, 27);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(143, 56);
            this.button1.TabIndex = 8;
            this.button1.Text = "QUAY LẠI";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ThongTinAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.TextBoxPhuongThuc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TextBoxMatKhau1);
            this.Controls.Add(this.TextBoxTaiKhoan1);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.labelUserName);
            this.Controls.Add(this.label1);
            this.Name = "ThongTinAdmin";
            this.Text = "Thong_Tin_Admin";
            this.Load += new System.EventHandler(this.ThongTinAdmin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelUserName;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TextBoxTaiKhoan1;
        private System.Windows.Forms.TextBox TextBoxMatKhau1;
        private System.Windows.Forms.TextBox TextBoxPhuongThuc;
        private System.Windows.Forms.Button button1;
    }
}