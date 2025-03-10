using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SVinhKVinh.Home
{
    public partial class ManHinhChinh: Form
    {
        public string StrTaiKhoan;
        public string StrMatKhau;
        public string StrPhuongThuc;
        public ManHinhChinh()
        {
            InitializeComponent();
        }
        public ManHinhChinh(string a,string b, string c)
        {
            InitializeComponent();
            StrPhuongThuc = a;
            StrTaiKhoan = b;
            StrMatKhau = c;
        }

        private void ManHinChinh_FormClosed(object sender, FormClosedEventArgs e)
        {
        }
        private void adminstatorToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        
        private void thôngTinĐăngNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {   
            this.Hide();
            ThongTinAdmin t=new ThongTinAdmin(StrPhuongThuc,StrTaiKhoan,StrMatKhau);
            t.ShowDialog();
            this.Show();
        }

        private void thoátỨngDụngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void sửaThôngTinĐăngNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SuaThongTinDangNhap s= new SuaThongTinDangNhap(StrPhuongThuc, StrTaiKhoan, StrMatKhau); 
            this.Hide();
            s.ShowDialog();
            this.Show();
        }
    }
}
