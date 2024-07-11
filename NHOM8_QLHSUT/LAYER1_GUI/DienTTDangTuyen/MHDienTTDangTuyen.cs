using NHOM8_QLHSUT.LAYER1_GUI.ThanhToan;
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

namespace NHOM8_QLHSUT.LAYER1_GUI.DienTTDangTuyen
{
    public partial class MHDienTTDangTuyen : Form
    {
        ThongTinDangTuyen data = new ThongTinDangTuyen();
        public MHDienTTDangTuyen()
        {
            InitializeComponent();
        }

        private void fDienTTDangTuyen_Load(object sender, EventArgs e)
        {
            txtMaDT.Text = data.getAutoMaDangTuyen();
            txtMaDT.Enabled = false;    
            
        }


        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {  
            bool check = data.setThongTinDangTuyen(txtMaDT.Text, txtThongTinYC.Text, txtNgayBD.Value, txtNgayKT.Value, txtSoLuong.Text, txtViTri.Text, txtHinhThuc.Text, txtMaDN.Text);
            if (check)
            {
               // data.ThemTTDangTuyen(data);
                MHThanhToan f = new MHThanhToan(data, 0);
                this.Hide();
                f.ShowDialog();

                this.Show();
                MHDienTTDangTuyen form = new MHDienTTDangTuyen();
                this.Dispose();
                form.ShowDialog();
            }
        }
    }
}
