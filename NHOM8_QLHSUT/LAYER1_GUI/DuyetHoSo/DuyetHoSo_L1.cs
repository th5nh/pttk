using NHOM8_QLHSUT.LAYER2_BLL.DuyetHoSo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NHOM8_QLHSUT
{
    public partial class DuyetHoSo_L1 : Form
    {
        public DuyetHoSo_L1()
        {
            InitializeComponent();
            label7.Visible = false;
            label8.Visible = false;
        }

        private void bt_capnhat_Click(object sender, EventArgs e)
        {
            if (dtg_dangtuyen.Rows.Count == 0)
            {
                label7.Text = "Bạn cần tìm kiếm thông tin đăng tuyển và mã ứng viên trước";
                label7.Visible = true;
            }
            else if (dtg_ungtuyen.Rows.Count <= 1)
            {
                label7.Text = "Không thể cập nhật trên dữ liệu rỗng";
                label7.Visible = true;
            }
            else
            {
                DuyetHoSo_L2.CapNhat(tb_Dangtuyen.Text,tb_ungvien.Text,cb_tinhtrang.SelectedItem.ToString());
                DataTable dt = DuyetHoSo_L2.LayThongTinUngTuyen(tb_Dangtuyen.Text, tb_ungvien.Text);
                dtg_ungtuyen.DataSource = dt;
                label7.Visible = false;
            }

        }

        private void bt_tim_Click(object sender, EventArgs e)
        {
            if(tb_Dangtuyen.Text== "" || tb_ungvien.Text=="")
            {
                label8.Visible = true;
                DataTable dt = null;
                dtg_dangtuyen.DataSource = dt;
                dtg_ungvien.DataSource = dt;
                dtg_ungtuyen.DataSource = dt;
            }
            else
            {
                DataTable dt = DuyetHoSo_L2.LayThongTinDangTuyen(tb_Dangtuyen.Text);
                dtg_dangtuyen.DataSource = dt;
                dt = DuyetHoSo_L2.LayThongTinUngVien(tb_ungvien.Text);
                dtg_ungvien.DataSource = dt;
                dt = DuyetHoSo_L2.LayThongTinUngTuyen(tb_Dangtuyen.Text, tb_ungvien.Text);
                dtg_ungtuyen.DataSource = dt;
                label8.Visible = false;
            }
            
        }


    }
}
