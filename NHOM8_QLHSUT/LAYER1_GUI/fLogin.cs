using NHOM8_QLHSUT.LAYER1_GUI.DienTTDangTuyen;
using NHOM8_QLHSUT.LAYER2_BLL.DienTTDangTuyen;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NHOM8_QLHSUT.LAYER1_GUI
{
    public partial class fLogin : Form
    {
        NhanVien data = new NhanVien();
        public fLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            data.setMaNV(txtUsername.Text);
            data.setMatKhau(txtPassword.Text);
            if(data.KiemTraDangNhap())
            {
                MHMenu f = new MHMenu(txtUsername.Text);
                this.Hide();
                f.ShowDialog();
                this.Show();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
