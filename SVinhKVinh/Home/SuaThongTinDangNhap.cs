
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SVinhKVinh.Home
{
    public partial class SuaThongTinDangNhap: Form
    {
        
        public SuaThongTinDangNhap()
        {
            InitializeComponent();
        }

        public SuaThongTinDangNhap(string a,string b, string c)
        {
            InitializeComponent();
            TextBoxPhuongThuc.Text = a;
            TextBoxTaiKhoan.Text = b;
            TextBoxMatKhau.Text = c;
        }
        private void TextBoxMatKhau1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBoxPass.Text != textBoxPass1.Text) { MessageBox.Show("Mật khẩu không trùng khớp. Vui lòng nhập lại mật khẩu!");}
            
            else
            {
                string ConnectionString = "Server=OHMYGOD\\HOSYVINH1510;Database=SVinhKVinh;User Id=sa;Password=vinh1510;";

                using (SqlConnection con = new SqlConnection(ConnectionString))
                {
                    con.Open();
                    if (TextBoxPhuongThuc.Text == "QUẢN TRỊ VIÊN")
                    {

                        string query = "UPDATE Admin_Login SET MatKhau = @pass WHERE TaiKhoan = @user";

                        SqlCommand cmd = new SqlCommand(query, con);
                        cmd.Parameters.Add(new SqlParameter("@user", SqlDbType.NVarChar, 50) { Value = TextBoxTaiKhoan.Text });
                        cmd.Parameters.Add(new SqlParameter("@pass", SqlDbType.NVarChar, 50) { Value = textBoxPass.Text });
                        cmd.ExecuteNonQuery();
                    }
                    else
                if (TextBoxPhuongThuc.Text == "NGƯỜI DÙNG")
                    {

                        string query = "UPDATE Nguoi_Dung_LogIn SET MatKhau = @pass WHERE TaiKhoan = @user";
                        con.Open();
                        SqlCommand cmd = new SqlCommand(query, con);
                        cmd.Parameters.Add(new SqlParameter("@user", SqlDbType.NVarChar, 50) { Value = TextBoxTaiKhoan.Text });
                        cmd.Parameters.Add(new SqlParameter("@pass", SqlDbType.NVarChar, 50) { Value = textBoxPass.Text });
                        cmd.ExecuteNonQuery();
                    }
                }             
               
                MessageBox.Show("Thay đổi mật khẩu thành công!");
                this.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
