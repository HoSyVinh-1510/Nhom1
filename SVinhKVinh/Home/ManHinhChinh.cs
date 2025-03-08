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
        public ManHinhChinh()
        {
            InitializeComponent();
        }


        private void ManHinChinh_Move(object sender, EventArgs e)
        {

        }

        private void ManHinChinh_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }

        private void ManHinhChinh_Load(object sender, EventArgs e)
        {

        }

        private void adminstatorToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        
        private void thôngTinĐăngNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ThongTinAdmin thong_Tin_Admin = new ThongTinAdmin();           
            this.Hide();
            thong_Tin_Admin.ShowDialog();         
            this.Show();
        }

        private void thoátỨngDụngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            Login l = new Login();
            l.Show();
        }

        private void sửaThôngTinĐăngNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
