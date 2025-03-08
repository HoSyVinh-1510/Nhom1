using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SVinhKVinh.Home
{
    public partial class ThongTinAdmin: Form
    {
        
        public ThongTinAdmin()
        {
            InitializeComponent();
            TextBoxPhuongThuc.Text = "Tài Khoản";
            TextBoxTaiKhoan1.Text = "admin";
            TextBoxMatKhau1.Text = "admin";

        }

        private void TextBoxPhuongThuc_TextChanged(object sender, EventArgs e)
        {
            return;
        }

        private void TextBoxTaiKhoan1_TextChanged(object sender, EventArgs e)
        {
            return;
        }

        private void TextBoxMatKhau1_TextChanged(object sender, EventArgs e)
        {
            return;
        }

        private void button1_Click(object sender, EventArgs e)
        {   

            this.Close();            
            ManHinhChinh m= new ManHinhChinh();
            m.Show();
            this.Hide();
        }
    }
}
