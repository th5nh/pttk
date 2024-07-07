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
            if(txtMaDT.Text == null || txtThongTinYC.Text == null | txtNgayBD.Value == null || txtNgayKT.Value == null || txtSoLuong.Text.Length <= 0 || txtViTri.Text == null || txtHinhThuc.Text == null || txtMaDN.Text == null)
            {
                MessageBox.Show("Không được để trống các thông tin");
            }
            else
            {
                data.setThongTinDangTuyen(txtMaDT.Text, txtThongTinYC.Text, txtNgayBD.Value, txtNgayKT.Value, int.Parse(txtSoLuong.Text), txtViTri.Text, txtHinhThuc.Text, txtMaDN.Text);
                MHPhieuDangKyQuangCao f = new MHPhieuDangKyQuangCao(data);
                this.Hide();
                f.ShowDialog();

                this.Show();
            }
        }
    }
}
