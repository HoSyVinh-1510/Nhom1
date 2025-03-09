using SVinhKVinh.Home;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace SVinhKVinh
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

      
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát ứng dụng không?","Thông báo",MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
                e.Cancel = true;
        }

        private bool CheckLogin(string taikhoan, string matkhau)
        {
            string ConnectionString = "Server=OHMYGOD\\HOSYVINH1510;Database=SVinhKVinh;User Id=sa;Password=vinh1510;";
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {   
                int count=0;
                if (radioButton1.Checked)
                {
                    string query = 
                "SELECT COUNT(*) FROM Admin_Login WHERE TaiKhoan COLLATE SQL_Latin1_General_CP1_CS_AS = @user AND MatKhau COLLATE SQL_Latin1_General_CP1_CS_AS  = @pass";
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.Add(new SqlParameter("@user", SqlDbType.NVarChar,50) { Value = taikhoan });
                    cmd.Parameters.Add(new SqlParameter("@pass", SqlDbType.NVarChar,50) { Value = matkhau });
                    count = (int)cmd.ExecuteScalar();
                    return count > 0;

                }
                else
                {
                    string query = "SELECT COUNT(*) FROM Nguoi_Dung_LogIn WHERE TaiKhoan = @user AND MatKhau = @pass";
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.Add(new SqlParameter("@user", SqlDbType.NVarChar,50) { Value = taikhoan });
                    cmd.Parameters.Add(new SqlParameter("@pass", SqlDbType.NVarChar,50) { Value = matkhau });
                    count = (int)cmd.ExecuteScalar();
                    return count > 0;
                }
            }
        }
        private void buttonLongIn_Click_1(object sender, EventArgs e)
        {
            string username = TextBoxTaiKhoan.Text;
            string password = TextBoxMatKhau.Text;
            string method;

            if (radioButton1.Checked)
            {
                method = radioButton1.Text;
            }
            else
            {
                method = radioButton2.Text;
            }
            if (CheckLogin(username, password))
            {

                MessageBox.Show("Đăng nhập thành công");    
                this.Hide();
                ManHinhChinh m=new ManHinhChinh(method,username,password);
                m.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Tài khoản hoặc mật khẩu chưa chính xác!");
            }

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Login_ChangeUICues(object sender, UICuesEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonLongIn_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void buttonLongIn_DragEnter(object sender, DragEventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            
        }
        
    }
}
