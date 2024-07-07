﻿using NHOM8_QLHSUT.LAYER1_GUI.ManHinhChinh;
using NHOM8_QLHSUT.LAYER2_BLL.DangThongBaoTuyenDung;
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
    public partial class MHDangThongBaoTuyenDung : Form
    {
        public MHDangThongBaoTuyenDung()
        {
            InitializeComponent();
        }
    

        private void DangThongBao_L1_Load(object sender, EventArgs e)
        {
            DataTable dt = DangThongBaoTuyenDung_L2.ThongBaoDangTuyen();
            foreach (DataRow dr in dt.Rows)
            {
                DSThongTinDangTuyen.Rows.Add(dr.ItemArray);
            }
        }


        private void btnQuaylai(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
