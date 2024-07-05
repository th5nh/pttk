using NHOM8_QLHSUT.LAYER3_DAL;
using NHOM8_QLHSUT.LAYER1_GUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using NHOM8_QLHSUT.LAYER1_GUI.DienTTDangTuyen;

namespace NHOM8_QLHSUT
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

            if(DataAccess.Connect())
            {
                Application.Run(new fLogin());
            }
        }
    }
}
