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

namespace NHOM8_QLHSUT.LAYER1_GUI.ThanhToan_Huy
{
    public partial class MHDSThanhToan : Form
    {
        ThongTinDangTuyen data = new ThongTinDangTuyen();
        public MHDSThanhToan()
        {
            InitializeComponent();
        }

        private void AddButtonColumn(string colName, string colText)
        {
            DataGridViewButtonColumn buttonColumn = new DataGridViewButtonColumn();
            buttonColumn.Name = colName;
            buttonColumn.HeaderText = "";
            buttonColumn.Text = colText;
            buttonColumn.UseColumnTextForButtonValue = true;
            gridThongTinDangTuyen.Columns.Add(buttonColumn);
        }

        public void getAllData()
        {
            gridThongTinDangTuyen.DataSource = data.getAllThongTinDangTuyen();
        }

        private void MHDSThanhToan_Load(object sender, EventArgs e)
        {
            getAllData();
            AddButtonColumn("btnThanhToan", "Thanh Toán");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gridThongTinDangTuyen_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == gridThongTinDangTuyen.Columns["btnThanhToan"].Index && e.RowIndex >= 0)
            {
                DataGridViewRow row = gridThongTinDangTuyen.Rows[e.RowIndex];
                string MaDT = row.Cells["MaDT"].Value.ToString();
                ThongTinDangTuyen data_2 = new ThongTinDangTuyen();
                data_2.setMaDT(MaDT);
                data_2.getThongTinDangTuyen();

                MessageBox.Show(data_2.getViTri());

                MHDienTTDangTuyen f = new MHDienTTDangTuyen();
                this.Hide();
                f.ShowDialog();
                this.Show();

                MHDSThanhToan form = new MHDSThanhToan();
                this.Dispose();
                form.ShowDialog();
            }
            else
            {
                DataGridViewRow row = gridThongTinDangTuyen.Rows[e.RowIndex];
                string MaDT = row.Cells["MaDT"].Value.ToString();
                ThongTinDangTuyen data_2 = new ThongTinDangTuyen();
                data_2.setMaDT(MaDT);
                data_2.getThongTinDangTuyen();

                txtMaDT.Text = data_2.MaDT;
                txtMaDN.Text = data_2.MaDN;
                txtNgayBD.Text = data_2.NgayBD.ToString();
                txtNgayKT.Text = data_2.NgayKT.ToString();
                txtHinhThuc.Text = data_2.HinhThucDangTuyen;
                txtSoLuong.Text = data_2.SoLuongTuyenDung.ToString();
                txtViTri.Text = data_2.ViTriTuyenDung;
                txtThongTinYeuCau.Text = data_2.ThongTinYeuCau;
            }
        }
    }
}
