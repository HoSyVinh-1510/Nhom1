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
        }
        public ThongTinAdmin(string a, string b,string c)
        {
            InitializeComponent();
            TextBoxTaiKhoan1.Text = b;
            TextBoxMatKhau1.Text = c;
            TextBoxPhuongThuc.Text = a;
        }
        private void TextBoxPhuongThuc_TextChanged(object sender, EventArgs e)
        {
        
        }

        private void TextBoxTaiKhoan1_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void TextBoxMatKhau1_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void button1_Click(object sender, EventArgs e)
        {   
            this.Close(); 
        }
    }
}
