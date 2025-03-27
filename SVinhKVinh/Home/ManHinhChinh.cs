﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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
            // TODO: This line of code loads data into the 'hoaDon.HoaDonNuoc' table. You can move, or remove it, as needed.
            this.hoaDonNuocTableAdapter.Fill(this.hoaDon.HoaDonNuoc);
            // TODO: This line of code loads data into the 'hoaDon.HoaDonDien' table. You can move, or remove it, as needed.
            this.hoaDonDienTableAdapter.Fill(this.hoaDon.HoaDonDien);
            // TODO: This line of code loads data into the 'thongTinChuHo.Thong_Tin_Chu_Ho' table. You can move, or remove it, as needed.
            this.thong_Tin_Chu_HoTableAdapter.Fill(this.thongTinChuHo.Thong_Tin_Chu_Ho);
            // TODO: This line of code loads data into the 'thongTinChuHo.Thong_Tin_Chu_Ho' table. You can move, or remove it, as needed.
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

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (comboBox1.SelectedItem == null) 
            {   
                MessageBox.Show("Bạn cần phải chọn một bộ lọc","Hồ Sỹ Vinh said that:");
                return; 
            }
            string SoPhong = comboBox1.SelectedItem.ToString(); 
            MessageBox.Show("Hiển thị dữ liệu của: " + SoPhong);
            thongTinChuHoBindingSource.RemoveFilter();
            if (SoPhong=="All") SoPhong = null;
            if (SoPhong == null)
            {
                this.thong_Tin_Chu_HoTableAdapter.Fill(this.thongTinChuHo.Thong_Tin_Chu_Ho);
            }        
            else
            {
                thongTinChuHoBindingSource.Filter = $"SoPhong='{SoPhong}'";             
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            comboBox1.SelectedItem = null;
            thongTinChuHoBindingSource.RemoveFilter();
            MessageBox.Show("Xóa tìm kiếm!", "Hồ Sỹ Vinh notificate:");
            this.thong_Tin_Chu_HoTableAdapter.Fill(this.thongTinChuHo.Thong_Tin_Chu_Ho);

        }

        private void button3_Click(object sender, EventArgs e)
        {          
            dataGridView2.DataSource = null;

        }

        private void button4_Click(object sender, EventArgs e)
        {

          
            if (comboBox2.SelectedItem == null || comboBox3.SelectedItem == null)
            {
                MessageBox.Show("Bạn cần phải chọn bộ lọc ! Không thể hiện 2 bảng cùng 1 lúc", "Hồ Sỹ Vinh said that:");
                return;
            }
           string SoPhong = comboBox2.SelectedItem.ToString();
           string LoaiDichVu = comboBox3.SelectedItem.ToString();
            if (SoPhong == "Tất cả")
            {
                if (LoaiDichVu == "Hóa đơn điện")
                {   dataGridView2.DataSource = hoaDonDienBindingSource;
                    this.hoaDonDienTableAdapter.Fill(this.hoaDon.HoaDonDien); 
                }
                if (LoaiDichVu == "Hóa đơn nước")
                { 
                    dataGridView2.DataSource = hoaDonNuocBindingSource;
                    this.hoaDonNuocTableAdapter.Fill(this.hoaDon.HoaDonNuoc);
                }
            }
            else
            {
                if (LoaiDichVu == "Hóa đơn điện") { dataGridView2.DataSource = hoaDonDienBindingSource;
                    this.hoaDonDienBindingSource.Filter = $"SoPhong='{SoPhong}'"; }
                if (LoaiDichVu == "Hóa đơn nước") {
                    dataGridView2.DataSource = hoaDonNuocBindingSource;
                    this.hoaDonNuocBindingSource.Filter = $"SoPhong='{SoPhong}'"; }
            }
        }


        private void button5_Click(object sender, EventArgs e)
        {
            this.ThemPhong();
        }

        private void ThemPhong()
        {
            try
            {
                string SoPhong = textBox1.Text;
                string HoTen = textBox2.Text;
                DateTime NgaySinh;
                if (!DateTime.TryParse(textBox3.Text, out NgaySinh))
                {
                    MessageBox.Show("Ngày tháng không hợp lệ. Vui lòng nhập lại. Định dạng ngày tháng dd/mm/yyyy", "Hồ Sỹ Vinh said that:");
                }
                string GioiTinh = textBox4.Text;
                string CCCD = textBox5.Text;
                string IDKhachHang = textBox6.Text;
                DateTime NgaySuDung;
                if (!DateTime.TryParse(textBox7.Text, out NgaySuDung))
                {
                    MessageBox.Show("Ngày tháng không hợp lệ. Vui lòng nhập lại. Định dạng ngày tháng dd/mm/yyyy", "Hồ Sỹ Vinh said that:");
                }
                // Mở kết nối SQL
                string strCon = @"Server=OHMYGOD\HOSYVINH1510;Database=SVinhKVinh;User Id=sa;Password=vinh1510";
                using (SqlConnection conn = new SqlConnection(strCon))
                {
                    conn.Open();
                    string query = "INSERT INTO Thong_Tin_Chu_Ho VALUES(@SoPhong,@HoTen,@NgaySinh,@GioiTinh,@CCCD,@IDKhachHang,@NgaySuDung)";
                    using (SqlCommand cmd= new SqlCommand(query,conn) )
                    {
                        cmd.Parameters.AddWithValue("@SoPhong", SoPhong);
                        cmd.Parameters.AddWithValue("@HoTen", HoTen);
                        cmd.Parameters.AddWithValue("@NgaySinh", NgaySinh);
                        cmd.Parameters.AddWithValue("@GioiTinh", GioiTinh);
                        cmd.Parameters.AddWithValue("@CCCD", CCCD);
                        cmd.Parameters.AddWithValue("@IDKhachHang",IDKhachHang);
                        cmd.Parameters.AddWithValue("@NgaySuDung", NgaySuDung);
                        cmd.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("Thêm phòng thành công", "THÔNG BÁO:");

                this.thong_Tin_Chu_HoTableAdapter.Fill(this.thongTinChuHo.Thong_Tin_Chu_Ho);

                comboBox1.Items.Add(textBox1.Text);
                comboBox4.Items.Add(textBox1.Text);               
            }           
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi");
            }
            return;
        }

        private void XoaPhong()
        {
            try
            {
                string SoPhong = comboBox4.SelectedItem.ToString();
                if (SoPhong == null) return;
                string strCon = @"Server=OHMYGOD\HOSYVINH1510;Database=SVinhKVinh;User Id=sa;Password=vinh1510";
                using (SqlConnection conn = new SqlConnection(strCon))
                {
                    conn.Open();
                    string query;
                    if (SoPhong == "All")  query= "DELETE FROM Thong_Tin_Chu_Ho";
                    else  query = "DELETE FROM Thong_Tin_Chu_Ho WHERE SoPhong=@SoPhong";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@SoPhong", SoPhong);
                        cmd.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("Xóa phòng thành công", "Hồ Sỹ Vinh notificate:");
                this.thong_Tin_Chu_HoTableAdapter.Fill(this.thongTinChuHo.Thong_Tin_Chu_Ho);
                comboBox1.Items.Remove(textBox1.Text);
                comboBox4.Items.Remove(textBox1.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi");
            }
            return;
        }


        private void textBox3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Định dạng ngày dd//mm/yyyy");
        }

        private void textBox7_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Định dạng ngày dd//mm/yyyy");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.XoaPhong();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }
    }

   
}
