using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //for testing:
            //Application.Run(new EmployeDetailForm());
            //Application.Run(new Customer());
            //Application.Run(new Sales.Sale());
            Application.Run(new LoginPage());

        }
        

   }
}
