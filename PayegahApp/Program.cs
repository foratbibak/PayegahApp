using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using PayegahApp.Loginforms;

namespace PayegahApp
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            using (frmLogin login = new frmLogin())
            {
                if (login.ShowDialog() == DialogResult.OK)
                {
                    Application.Run(new FrmDashboard());
                }
                else
                {
                    // اگر لاگین درست نبود یا کاربر زد ضربدر، کل برنامه ببنده
                    Application.Exit();
                }
            }
        }
    }
}
