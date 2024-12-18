using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StoreManage
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new AdminMainForm());
<<<<<<< HEAD
            //Application.Run(new MainForm());
=======
            Application.Run(new MainForm());
>>>>>>> origin/Bao
            //Application.Run(new LoginForm());
            Application.Run(new AdminLoginForm());


        }
    }
}
