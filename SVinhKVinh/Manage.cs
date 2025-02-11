using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SVinhKVinh
{
    public partial class Manage : Form
    {
        public Manage()
        {
            InitializeComponent();
        }

        private void Manage_Load(object sender, EventArgs e)
        {

        }

        private void adminToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void thôngTinTàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

       
        private void CNTT1_ControlAdded(object sender, ControlEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void đăngXuấtToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void sửaThôngTinĐăngNhậpToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            PrepairAdmin p = new PrepairAdmin();
            this.Hide();
            p.ShowDialog();
            this.Show();
        }

        private void thôngTinQuảnLýChungCưToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InforManage i = new InforManage();
            this.Hide();
            i.ShowDialog();
            this.Show();
        }
    }
}
