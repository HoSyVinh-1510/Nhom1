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
        private string SoPhong = "Tất cả";
        public ManHinhChinh()
        {
            InitializeComponent();

        }
        public ManHinhChinh(string a, string b, string c)
        {
            InitializeComponent();
            StrPhuongThuc = a;
            StrTaiKhoan = b;
            StrMatKhau = c;
            User.Text = $"Xin chào,  {b}";
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

        private void User_Click(object sender, EventArgs e)
        {

        }

        private void ManHinhChinh_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sVinhKVinhDataSet.Thong_Tin_Chu_Ho' table. You can move, or remove it, as needed.
            this.thong_Tin_Chu_HoTableAdapter.Fill(this.sVinhKVinhDataSet.Thong_Tin_Chu_Ho);
        }

        private void thongTinChuHoBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex==-1) return;
            DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
            int x = e.ColumnIndex;
            MessageBox.Show(" Dữ liệu ô: " + row.Cells[x].Value.ToString());
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == null) 
            {   
                MessageBox.Show("Bạn cần phải chọn một bộ lọc","Hồ Sỹ Vinh said that:");
                return; 
            }
            SoPhong = comboBox1.SelectedItem.ToString(); 
            MessageBox.Show("Hiển thị dữ liệu của: " + SoPhong);
            if (SoPhong == "Tất cả" || SoPhong==null)
            {
                this.thong_Tin_Chu_HoTableAdapter.Fill(this.sVinhKVinhDataSet.Thong_Tin_Chu_Ho);
            }
            else
            {
                this.thong_Tin_Chu_HoTableAdapter.FillBy(this.sVinhKVinhDataSet.Thong_Tin_Chu_Ho, SoPhong);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            comboBox1.SelectedItem = null;
            this.thong_Tin_Chu_HoTableAdapter.Fill(this.sVinhKVinhDataSet.Thong_Tin_Chu_Ho);
        }
    }
}
