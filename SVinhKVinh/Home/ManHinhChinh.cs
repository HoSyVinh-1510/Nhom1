using DevExpress.Xpo.DB.Helpers;
using System;
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
    public partial class ManHinhChinh : Form
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
            ThongTinAdmin t = new ThongTinAdmin(StrPhuongThuc, StrTaiKhoan, StrMatKhau);
            t.ShowDialog();
            this.Show();
        }

        private void thoátỨngDụngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void sửaThôngTinĐăngNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SuaThongTinDangNhap s = new SuaThongTinDangNhap(StrPhuongThuc, StrTaiKhoan, StrMatKhau);
            this.Hide();
            s.ShowDialog();
            this.Show();
        }

        private void User_Click(object sender, EventArgs e)
        {

        }

        private void ManHinhChinh_Load(object sender, EventArgs e)
        {
            this.thong_Tin_Chu_HoTableAdapter.Fill(this.thongTinChuHo.Thong_Tin_Chu_Ho);
            // TODO: This line of code loads data into the 'sVinhKVinhDataSet.HoaDonNuoc' table. You can move, or remove it, as needed.
            this.hoaDonNuocTableAdapter.Fill(this.sVinhKVinhDataSet.HoaDonNuoc);
            // TODO: This line of code loads data into the 'sVinhKVinhDataSet.HoaDonDien' table. You can move, or remove it, as needed.
            this.hoaDonDienTableAdapter.Fill(this.sVinhKVinhDataSet.HoaDonDien);

        }

        private void thongTinChuHoBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;
            DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
            int x = e.ColumnIndex;
            MessageBox.Show(" Dữ liệu ô: " + row.Cells[x].Value.ToString());
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (comboBox1.SelectedItem == null)
            {
                MessageBox.Show("Bạn cần phải chọn một bộ lọc", "Hồ Sỹ Vinh said that:");
                return;
            }
            string SoPhong = comboBox1.SelectedItem.ToString();
            MessageBox.Show("Hiển thị dữ liệu của: " + SoPhong);
            thongTinChuHoBindingSource.RemoveFilter();
            if (SoPhong == "All") SoPhong = null;
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
            dataGridView2.DataSource = null;

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
                {
                    dataGridView2.DataSource = hoaDonDienBindingSource;
                    this.hoaDonDienTableAdapter.Fill(this.sVinhKVinhDataSet.HoaDonDien);
                    return;
                }
                if (LoaiDichVu == "Hóa đơn nước")
                {

                    dataGridView2.DataSource = hoaDonNuocBindingSource;
                    this.hoaDonNuocTableAdapter.Fill(this.sVinhKVinhDataSet.HoaDonNuoc);
                    return;
                }
            }
                     
                if (LoaiDichVu == "Hóa đơn điện")
                {
                    dataGridView2.DataSource = hoaDonDienBindingSource;
                    this.hoaDonDienBindingSource.Filter = $"SoPhong='{SoPhong}'";
                return;
                }
                if (LoaiDichVu == "Hóa đơn nước")
                {

                    dataGridView2.DataSource = hoaDonNuocBindingSource;
                    this.hoaDonNuocBindingSource.Filter = $"SoPhong='{SoPhong}'";
                return;
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
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@SoPhong", SoPhong);
                        cmd.Parameters.AddWithValue("@HoTen", HoTen);
                        cmd.Parameters.AddWithValue("@NgaySinh", NgaySinh);
                        cmd.Parameters.AddWithValue("@GioiTinh", GioiTinh);
                        cmd.Parameters.AddWithValue("@CCCD", CCCD);
                        cmd.Parameters.AddWithValue("@IDKhachHang", IDKhachHang);
                        cmd.Parameters.AddWithValue("@NgaySuDung", NgaySuDung);
                        cmd.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("Thêm phòng thành công", "THÔNG BÁO:");

                this.thong_Tin_Chu_HoTableAdapter.Fill(this.thongTinChuHo.Thong_Tin_Chu_Ho);

                comboBox1.Items.Add(textBox1.Text);
                comboBox4.Items.Add(textBox1.Text);
                comboBox14.Items.Add(textBox1.Text);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Thêm phòng không thành công! " , "Lỗi");
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
                    if (SoPhong == "All") query = "DELETE FROM Thong_Tin_Chu_Ho";
                    else query = "DELETE FROM Thong_Tin_Chu_Ho WHERE SoPhong=@SoPhong";
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
                comboBox14.Items.Remove(textBox1.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(" Xảy ra lỗi khi xóa phòng! ", "Lỗi");
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

        //Hàm xóa phòng
        private void button6_Click(object sender, EventArgs e)
        {
            this.XoaPhong();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void ThemHoaDon()
        {
            string SoPhong = comboBox5.SelectedItem.ToString();
            string LoaiDichVu = comboBox6.SelectedItem.ToString();
            string Nam = comboBox8.SelectedItem.ToString();
            string Thang = comboBox7.SelectedItem.ToString();
            string SoSuDung = textBox9.Text;
            string trangthai = comboBox9.SelectedItem.ToString();

            double sosudung; double tien;
            if (double.TryParse(SoSuDung, out sosudung) == false)
            {
                MessageBox.Show("Số sử dụng không hợp lệ. Vui lòng nhập lại", "Hồ Sỹ Vinh said that:");
                return;
            }
            if (LoaiDichVu == null)
            {
                MessageBox.Show("Bạn phải chọn loại hóa đơn", "Hồ Sỹ Vinh said that:");
                return;
            }
            if (LoaiDichVu == "Hóa đơn điện")
            {

                if (sosudung <= 50) tien = sosudung * 1.8;
                else if (sosudung <= 100) tien = (sosudung - 50) * 1.9 + 50 * 1.8;
                else if (sosudung <= 200) tien = (sosudung - 100) * 2.1 + 50 * 1.8 + 50 * 1.9;
                else tien = (sosudung - 200) * 2.5 + 50 * 1.8 + 50 * 1.9 + 100 * 2.1;
            }
            else
            {
                if (sosudung <= 10) tien = sosudung * 6;
                else if (sosudung <= 20) tien = (sosudung - 10) * 7 + 10 * 6;
                else if (sosudung <= 30) tien = (sosudung - 20) * 8.6 + 10 * 6 + 10 * 7;
                else tien = (sosudung - 30) * 15 + 10 * 6 + 10 * 7 + 10 * 8.6;
            }
            textBox10.Text = tien.ToString();

            string strCon = @"Server=OHMYGOD\HOSYVINH1510;Database=SVinhKVinh;User Id=sa;Password=vinh1510";
            using (SqlConnection conn = new SqlConnection(strCon))
            {
                conn.Open();
                string query;
                if (LoaiDichVu == "Hóa đơn điện") query = "INSERT INTO HoaDonDien VALUES (@SoPhong,@Nam,@Thang,@SoSuDung,@Tien,@TrangThai) ";
                else query = "INSERT INTO HoaDonNuoc VALUES (@SoPhong,@Nam,@Thang,@SoSuDung,@Tien,@TrangThai) ";

                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@SoPhong", SoPhong);
                cmd.Parameters.AddWithValue("@Nam", Nam);
                cmd.Parameters.AddWithValue("@Thang", Thang);
                cmd.Parameters.AddWithValue("@SoSuDung", SoSuDung);
                cmd.Parameters.AddWithValue("@Tien", tien.ToString());
                cmd.Parameters.AddWithValue("@TrangThai", trangthai);
                cmd.ExecuteNonQuery();
            }
            

            comboBox5.SelectedItem = null;
            comboBox6.SelectedItem = null;
            comboBox7.SelectedItem = null;
            comboBox8.SelectedItem = null;
            comboBox9.SelectedItem = null;
            textBox9.Text = null;
            textBox10.Text = null;
            return;

        }

        //Hàm sửa Phòng

        private void SuaThongTinChuHo()
        {
            string SoPhong = comboBox14.SelectedItem.ToString();
            string HoTen = textBox8.Text;
            string NgaySinh = textBox11.Text;
            DateTime datebirth;
            if (!DateTime.TryParse(NgaySinh, out datebirth))
            {
                MessageBox.Show("Ngày tháng không hợp lệ. Vui lòng nhập lại. Định dạng ngày tháng dd/mm/yyyy", "Hồ Sỹ Vinh said that:");
                return;

            }
            string GioiTinh = textBox12.Text;
            string CCCD = textBox13.Text;
            string IDKhachHang = textBox14.Text;
            string NgaySuDung = textBox15.Text;
            DateTime dateuse;
            if (!DateTime.TryParse(NgaySuDung, out dateuse))
            {
                MessageBox.Show("Ngày tháng không hợp lệ. Vui lòng nhập lại. Định dạng ngày tháng dd/mm/yyyy", "Hồ Sỹ Vinh said that:");
                return;
            }
            string strCon = @"Server=OHMYGOD\HOSYVINH1510;Database=SVinhKVinh;User Id=sa;Password=vinh1510";
            using (SqlConnection conn = new SqlConnection(strCon))
            {
                string query = "UPDATE Thong_Tin_Chu_Ho SET HoTen=@HoTen,NgaySinh=@NgaySinh,GioiTinh=@GioiTinh,CCCD=@CCCD,IDKhachHang=@IDKhachHang,NgaySuDung=@NgaySuDung WHERE SoPhong=@SoPhong";
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@SoPhong", SoPhong);
                    cmd.Parameters.AddWithValue("@HoTen", HoTen);
                    cmd.Parameters.AddWithValue("@NgaySinh", datebirth);
                    cmd.Parameters.AddWithValue("@GioiTinh", GioiTinh);
                    cmd.Parameters.AddWithValue("@CCCD", CCCD);
                    cmd.Parameters.AddWithValue("@IDKhachHang", IDKhachHang);
                    cmd.Parameters.AddWithValue("@NgaySuDung", dateuse);
                    cmd.ExecuteNonQuery();
                }
                comboBox14.SelectedItem = null;
                textBox8.Text = null;
                textBox11.Text = null;
                textBox12.Text = null;
                textBox13.Text = null;
                textBox14.Text = null;
                textBox15.Text = null;
                return;
            }
        }

        // Hàm thêm hóa đơn
        private void button7_Click(object sender, EventArgs e)
        {
            this.ThemHoaDon();
            this.button4_Click(sender, e);
        }

        // Hàm xóa hóa đơn
        private void button8_Click(object sender, EventArgs e)
        {
            this.XoaHoaDon();
            MessageBox.Show("Xóa hóa đơn thành công", "Hồ Sỹ Vinh notificate:");
            this.button4_Click(sender, e);
        }

        private void XoaHoaDon()
        {
            string SoPhong = comboBox10.SelectedItem.ToString();
            string LoaiDichVu = comboBox11.SelectedItem.ToString();
            string Nam = comboBox12.SelectedItem.ToString();
            string Thang = comboBox13.SelectedItem.ToString();
            if (SoPhong == null || LoaiDichVu == null || Nam == null || Thang == null)
            {
                MessageBox.Show("Bạn phải chọn đủ thông tin để xóa hóa đơn", "Hồ Sỹ Vinh said that:");
                return;
            }
            string strCon = @"Server=OHMYGOD\HOSYVINH1510;Database=SVinhKVinh;User Id=sa;Password=vinh1510";
            using (SqlConnection conn = new SqlConnection(strCon))
            {
                conn.Open();
                string query;
                if (LoaiDichVu == "Hóa đơn điện") query = "DELETE FROM HoaDonDien WHERE (SoPhong=@SoPhong AND Nam=@Nam AND Thang=@Thang)";
                else query = "DELETE FROM HoaDonNuoc WHERE (SoPhong=@SoPhong AND Nam=@Nam AND Thang=@Thang)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@SoPhong", SoPhong);
                cmd.Parameters.AddWithValue("@Nam", Nam);
                cmd.Parameters.AddWithValue("@Thang", Thang);
                cmd.ExecuteNonQuery();
            }
            comboBox10.SelectedItem = null;
            comboBox11.SelectedItem = null;
            comboBox12.SelectedItem = null;
            comboBox13.SelectedItem = null;
            
            return;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.SuaThongTinChuHo();
            MessageBox.Show("Sửa thông tin chủ hộ thành công", "Hồ Sỹ Vinh notificate:");
            this.button1_Click(sender, e);           
            return;
        }

        private void trợGiúpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Help help = new Help();
            this.Hide();
            help.ShowDialog();
            this.Show();
        }

        private void SuaHoaDon(object sender, EventArgs e)
        {
            string SoPhong = comboBox10.SelectedItem.ToString();
            string LoaiDichVu = comboBox11.SelectedItem.ToString();
            string Nam = comboBox13.SelectedItem.ToString();
            string Thang = comboBox12.SelectedItem.ToString();
            if (SoPhong == null || LoaiDichVu == null || Nam == null || Thang == null)
            {
                MessageBox.Show("Bạn phải chọn đủ thông tin để SỬA hóa đơn", "Hồ Sỹ Vinh said that:");
                return;
            }
            double sosudung;
            double tien;
            string SoSuDung = textBox16.Text;
            string trangthai = comboBox15.SelectedItem.ToString();
            if (!double.TryParse(SoSuDung, out sosudung))
            {
                MessageBox.Show("Số sử dụng không hợp lệ. Vui lòng nhập lại", "Hồ Sỹ Vinh said that:");
                return;
            }
            if (LoaiDichVu == null)
            {
                MessageBox.Show("Bạn phải chọn loại hóa đơn", "Hồ Sỹ Vinh said that:");
                return;
            }
            if (LoaiDichVu == "Hóa đơn điện")
            {

                if (sosudung <= 50) tien = sosudung * 1.8;
                else if (sosudung <= 100) tien = (sosudung - 50) * 1.9 + 50 * 1.8;
                else if (sosudung <= 200) tien = (sosudung - 100) * 2.1 + 50 * 1.8 + 50 * 1.9;
                else tien = (sosudung - 200) * 2.5 + 50 * 1.8 + 50 * 1.9 + 100 * 2.1;
            }
            else
            {
                if (sosudung <= 10) tien = sosudung * 6;
                else if (sosudung <= 20) tien = (sosudung - 10) * 7 + 10 * 6;
                else if (sosudung <= 30) tien = (sosudung - 20) * 8.6 + 10 * 6 + 10 * 7;
                else tien = (sosudung - 30) * 15 + 10 * 6 + 10 * 7 + 10 * 8.6;
            }
            
            textBox17.Text = tien.ToString();

            string strCon = @"Server=OHMYGOD\HOSYVINH1510;Database=SVinhKVinh;User Id=sa;Password=vinh1510";
            using (SqlConnection conn = new SqlConnection(strCon))
            {
                conn.Open();
                string query;
                if (LoaiDichVu == "Hóa đơn điện") query = "UPDATE HoaDonDien SET SoDienSuDung=@SoSuDung,ThanhTien=@Tien,TrangThai=@TrangThai WHERE SoPhong=@SoPhong AND Nam=@Nam AND Thang=@Thang";
                else if(LoaiDichVu== "Hóa đơn nước") query = "UPDATE HoaDonNuoc SET SoNuocSuDung=@SoSuDung,ThanhTien=@Tien,TrangThai=@TrangThai WHERE SoPhong=@SoPhong AND Nam=@Nam AND Thang=@Thang";
                else 
                {
                    MessageBox.Show("Bạn phải chọn loại hóa đơn!", "Hồ Sỹ Vinh said that:");
                    return;
                }
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@SoPhong", SoPhong);
                cmd.Parameters.AddWithValue("@Nam", Nam);
                cmd.Parameters.AddWithValue("@Thang", Thang);
                cmd.Parameters.AddWithValue("@SoSuDung", sosudung);
                cmd.Parameters.AddWithValue("@Tien",tien);
                cmd.Parameters.AddWithValue("@TrangThai", trangthai);
                cmd.ExecuteNonQuery();
            }
            comboBox10.SelectedItem = null;
            comboBox11.SelectedItem = null;
            comboBox12.SelectedItem = null;
            comboBox13.SelectedItem = null;
            textBox16.Text = null;
            textBox17.Text = null;
            return;


        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.SuaHoaDon(sender, e);
            MessageBox.Show("Sửa hóa đơn thành công", "Hồ Sỹ Vinh notificate:");
            this.button4_Click(sender, e);
        }

        
    }


    }
