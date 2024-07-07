using NHOM8_QLHSUT.LAYER1_GUI.ThanhToan;
using NHOM8_QLHSUT.LAYER2_BLL.ThanhToan;
using NHOM8_QLHSUT.LAYER3_DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            ThongTinDangTuyen ttdt = new ThongTinDangTuyen();
            ttdt.setThongTinDangTuyen("DT0010", "Test", DateTime.Now, DateTime.Now, 1, "test", "test", "DN0001", 100000);
            if(DataAccess.Connect())
            {
                Application.Run(new ThanhToan_L1(ttdt));
            }
        }
    }
}
