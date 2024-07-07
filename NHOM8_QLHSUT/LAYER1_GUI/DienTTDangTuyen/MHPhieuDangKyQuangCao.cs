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
    public partial class MHPhieuDangKyQuangCao : Form
    {
        ThongTinDangTuyen data = new ThongTinDangTuyen();
        public MHPhieuDangKyQuangCao(ThongTinDangTuyen obj)
        {
            InitializeComponent();
            data.CopyFrom(obj);
        }

        public void setData()
        {
            txtMaDT.Text = data.MaDT;
            txtMaDN.Text =  data.MaDN;
            txtNgayBD.Text = data.NgayBD.ToString();
            txtNgayKT.Text = data.NgayKT.ToString();
            txtSoLuong.Text = data.SoLuongTuyenDung.ToString();
            txtViTri.Text = data.ViTriTuyenDung;
            txtYeuCau.Text = data.ThongTinYeuCau;
        }

        private void MHPhieuDangKyQuangCao_Load(object sender, EventArgs e)
        {
            setData();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
