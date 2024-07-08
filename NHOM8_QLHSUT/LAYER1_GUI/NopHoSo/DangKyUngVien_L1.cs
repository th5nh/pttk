using NHOM8_QLHSUT.LAYER1_GUI.ManHinhChinh;
using NHOM8_QLHSUT.LAYER2_BLL.NopHoSo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NHOM8_QLHSUT.LAYER1_GUI.NopHoSo
{
    public partial class DangKyUngVien_L1 : Form
    {
        public static string _manv = "NV0001"; //này sẽ lấy từ form đăng nhập, tạm thời để NV0001
        public DangKyUngVien_L1()
        {
            InitializeComponent();
        }

        private void DangKyUngVien_L1_Load(object sender, EventArgs e)
        {   
            tbao_mauv.Text = string.Empty;
            tbao_hoten.Text = string.Empty;
            tbao_diachi.Text = string.Empty;
            tbao_ngaysinh.Text = string.Empty;
            tbao_sdt.Text = string.Empty;
            tbao_email.Text = string.Empty;
        }

        private void btn_dangky_Click(object sender, EventArgs e)
        {
            bool checkID = DangKyUngVien_L2.KiemTraMaUV(txt_mauv.Text);
            bool checkPhone = DangKyUngVien_L2.KiemTraSDT(txt_sdt.Text);
            bool checkName = DangKyUngVien_L2.KiemTraHoTen(txt_hoten.Text);
            bool checkEmail = DangKyUngVien_L2.KiemTraEmail(txt_email.Text);
            bool checkBirth = DangKyUngVien_L2.KiemTraNgaySinh(dateTimePicker1);
            bool checkAddr = !string.IsNullOrEmpty(txt_diachi.Text);

            tbao_mauv.Text = checkID ? string.Empty : "Mã ứng viên bắt đầu bằng 'UV' theo sau là 4 chữ số";
            tbao_sdt.Text = checkPhone ? string.Empty : "Số điện thoại chỉ bao gồm 10 chữ số và bắt đầu từ 0";
            tbao_hoten.Text = checkName ? string.Empty : "Họ tên không bao gồm ký tự số và ký tự đặc biệt";
            tbao_email.Text = checkEmail ? string.Empty : "Email không hợp lệ";
            tbao_ngaysinh.Text = checkBirth ? string.Empty : "Ngày sinh phải nhỏ hơn ngày hiện tại";
            tbao_diachi.Text = checkAddr ? string.Empty : "Bắt buộc điền địa chỉ";

            if (string.IsNullOrEmpty(txt_mauv.Text)) tbao_mauv.Text = "Bắt buộc điền mã ứng viên";
            if (string.IsNullOrEmpty(txt_sdt.Text)) tbao_sdt.Text = "Bắt buộc điền số điện thoại";
            if (string.IsNullOrEmpty(txt_hoten.Text)) tbao_hoten.Text = "Bắt buộc điền họ tên";
            if (string.IsNullOrEmpty(txt_email.Text)) tbao_email.Text = "Bắt buộc điền email";

            if (checkID && checkPhone && checkName && checkEmail && checkBirth && checkAddr)
            {
                var dt = Convert.ToDateTime(dateTimePicker1.Value);
                string ngaySinh = dt.ToString("yyyy-MM-dd");

                if(DangKyUngVien_L2.ThemUngVien(txt_mauv.Text, txt_hoten.Text, ngaySinh, txt_diachi.Text, txt_sdt.Text, txt_email.Text, _manv))
                {
                    MessageBox.Show("Đăng ký ứng viên thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Đăng ký thất bại (Mã ứng viên đã tồn tại).", "Thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btn_trangchu_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
