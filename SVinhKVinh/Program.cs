using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;  
using System.Data.SqlClient;
namespace SVinhKVinh
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
          // string ConnectionString = "Server=OHMYGOD\\HOSYVINH1510;Database=SVinhKVinh;User Id=sa;Password=vinh1510;";
            // Server=myServerAddress;Database=myDataBase;Trusted_Connection=True;
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Login());
        }
    }
}
