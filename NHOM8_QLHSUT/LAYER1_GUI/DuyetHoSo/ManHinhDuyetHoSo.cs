using NHOM8_QLHSUT.LAYER2_BLL.DuyetHoSo;
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

namespace NHOM8_QLHSUT
{
    public partial class ManHinhDuyetHoSo : Form
    {
        public ManHinhDuyetHoSo()
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
                UngTuyen.CapNhat(tb_Dangtuyen.Text,tb_ungvien.Text,cb_tinhtrang.SelectedItem.ToString());
                DataTable dataTable2 = new DataTable();
                UngTuyen ut = UngTuyen.LayThongTinUngTuyen(tb_Dangtuyen.Text, tb_ungvien.Text);
                dataTable2.Columns.Add("BangCap", typeof(string));
                dataTable2.Columns.Add("ChungTu", typeof(string));
                dataTable2.Columns.Add("HoSo", typeof(string));
                dataTable2.Columns.Add("TinhTrang", typeof(string));
                dataTable2.Rows.Add(ut.BangCap, ut.ChungTu, ut.HoSo, ut.TinhTrang);
                dtg_ungtuyen.DataSource = dataTable2;
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
                DataTable dataTable0 = new DataTable();
                ThongTinDangTuyen ttdt = ThongTinDangTuyen.LayThongTinDangTuyen(tb_Dangtuyen.Text);
                if(ttdt.MaDT!=null)
                {
                    dataTable0.Columns.Add("MaDT", typeof(string));
                    dataTable0.Columns.Add("SLTuyenDung", typeof(int));
                    dataTable0.Columns.Add("ThongTinYeuCau", typeof(string));
                    dataTable0.Columns.Add("VitriTuyenDung", typeof(string));
                    dataTable0.Rows.Add(ttdt.MaDT, ttdt.SoLuongTuyenDung, ttdt.ThongTinYeuCau, ttdt.ViTriTuyenDung);
                    dtg_dangtuyen.DataSource = dataTable0;
                }
                DataTable dataTable1 = new DataTable();
                UngVien uv = UngVien.LayThongTinUngVien(tb_ungvien.Text);
                if (uv.HoTen != null)
                {
                    dataTable1.Columns.Add("HoTen", typeof(string));
                    dataTable1.Columns.Add("NgaySinh", typeof(string));
                    dataTable1.Columns.Add("DiaChi", typeof(string));
                    dataTable1.Columns.Add("SoDienThoai", typeof(string));
                    dataTable1.Rows.Add(uv.HoTen, uv.NgaySinh, uv.DiaChi, uv.SoDienThoai);
                    dtg_ungvien.DataSource = dataTable1;
                }
                   
                DataTable dataTable2 = new DataTable();
                UngTuyen ut = UngTuyen.LayThongTinUngTuyen(tb_Dangtuyen.Text, tb_ungvien.Text);
                if (ut.BangCap != null)
                {
                    dataTable2.Columns.Add("BangCap", typeof(string));
                    dataTable2.Columns.Add("ChungTu", typeof(string));
                    dataTable2.Columns.Add("HoSo", typeof(string));
                    dataTable2.Columns.Add("TinhTrang", typeof(string));
                    dataTable2.Rows.Add(ut.BangCap, ut.ChungTu, ut.HoSo, ut.TinhTrang);
                    dtg_ungtuyen.DataSource = dataTable2;
                }
                   
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
