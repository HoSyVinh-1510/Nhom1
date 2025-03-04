using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SVinhKVinh.Home
{
    public partial class ManHinChinh: Form
    {
        public ManHinChinh()
        {
            InitializeComponent();
        }

        private void ManHinChinh_Move(object sender, EventArgs e)
        {

        }

        private void ManHinChinh_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
            Login login = new Login();
            login.Show();
        }
    }
}
