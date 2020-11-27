using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Auth.GG_Winform_Example
{
    static class Program
    {
        /// <summary>
        /// Hello fellow crackers :)
        /// </summary>
        [STAThread]
        static void Main()
        {
            OnProgramStart.Initialize("  ", "   ", "   ", "  ");
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Login());
        }
    }
}
