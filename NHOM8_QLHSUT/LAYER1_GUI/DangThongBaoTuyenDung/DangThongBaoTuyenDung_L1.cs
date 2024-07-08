using NHOM8_QLHSUT.LAYER1_GUI.ManHinhChinh;
using NHOM8_QLHSUT.LAYER2_BLL.DienTTDangTuyen;
using NHOM8_QLHSUT.LAYER3_DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NHOM8_QLHSUT.LAYER1_GUI.DangThongBaoTuyenDung
{
    public partial class DangThongBaoTuyenDung_L1 : Form
    {
        ThongTinDangTuyen data = new ThongTinDangTuyen();
        public DangThongBaoTuyenDung_L1()
        {
            InitializeComponent();
        }

        private void AddCheckBoxColumn(string colName)
        {
            DataGridViewCheckBoxColumn checkBoxColumn = new DataGridViewCheckBoxColumn();
            checkBoxColumn.Name = colName;
            checkBoxColumn.HeaderText = "";
            DSThongTinDangTuyen.Columns.Add(checkBoxColumn);
        }


        private void DangThongBao_L1_Load(object sender, EventArgs e)
        {
            DataTable dt = data.LayTTDTChuaDuocDang();
            DSThongTinDangTuyen.DataSource = dt;
            AddCheckBoxColumn("ckbSelect");
        }


        private void btc_vtc_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            List<string> selectedMaDT = new List<string>();

            foreach (DataGridViewRow row in DSThongTinDangTuyen.Rows)
            {
                DataGridViewCheckBoxCell checkBoxCell = row.Cells["ckbSelect"] as DataGridViewCheckBoxCell;
                if (checkBoxCell != null && checkBoxCell.Value != null && (bool)checkBoxCell.Value)
                {
                    string maDT = row.Cells["MaDT"].Value.ToString();
                    selectedMaDT.Add(maDT);
                }
            }

            string[] selectedMaDTArray = selectedMaDT.ToArray();

            if (selectedMaDTArray.Length > 0)
            {
                data.updateTrangThaiTTDT(selectedMaDTArray);
            }
            else
            {
                MessageBox.Show("Không có mục nào được chọn.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
