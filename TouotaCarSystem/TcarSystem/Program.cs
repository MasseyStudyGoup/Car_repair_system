using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TcarSystem
{
    static class Program
    {
        /// <summary>
        ///program main enter
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            TcarLogin tlogin = new TcarLogin();
            Application.Run(new TcarLogin());

            
        }
    }
}
