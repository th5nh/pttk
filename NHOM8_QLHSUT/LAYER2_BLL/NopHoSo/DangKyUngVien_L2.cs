using NHOM8_QLHSUT.LAYER1_GUI.NopHoSo;
using NHOM8_QLHSUT.LAYER3_DAL;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NHOM8_QLHSUT.LAYER2_BLL.NopHoSo
{
    public class DangKyUngVien_L2
    {
        public static bool KiemTraSDT(string strPhone)
        {
            try
            {
                strPhone = strPhone.Replace(" ", "");
                if (string.IsNullOrEmpty(strPhone))
                {
                    return false;
                }
                var pattern = new Regex(@"^0+([0-9]{9})$");
                return pattern.IsMatch(strPhone);

            }
            catch (Exception)
            {
                return false;
            }
        }

        public static bool KiemTraHoTen(string strName)
        {
            try
            {
                strName = strName.Trim();
                if (string.IsNullOrEmpty(strName))
                {
                    return false;
                }
                var pattern = new Regex(@"^([^0-9!@#$%^&*()\-\+\=\[\]\{\}\:\;\'""_<,>.\/\?]*)$");
                return pattern.IsMatch(strName);

            }
            catch (Exception)
            {
                return false;
            }
        }

        public static bool KiemTraMaUV(string strMaUV)
        {
            try
            {
                strMaUV = strMaUV.Trim();
                if (string.IsNullOrEmpty(strMaUV))
                {
                    return false;
                }
                var pattern = new Regex(@"^UV+([0-9]{4})$");
                return pattern.IsMatch(strMaUV);

            }
            catch (Exception)
            {
                return false;
            }
        }

        public static bool KiemTraEmail(string strEmail)
        {
            try
            {
                strEmail = strEmail.Trim();
                if (string.IsNullOrEmpty(strEmail))
                {
                    return false;
                }
                var pattern = new Regex(@"^[\w\-\.]+@([\w-]+\.)+[\w-]{2,4}$");
                return pattern.IsMatch(strEmail);

            }
            catch (Exception)
            {
                return false;
            }
        }

        public static bool KiemTraNgaySinh (DateTimePicker ngaySinh)
        {
            if (ngaySinh.Value >= DateTime.Now.Date)
            {
                return false;
            }

            return true;
        }

        public static bool ThemUngVien(string mauv, string hoten, string ngaysinh, string diachi, string sdt, string email, string manv)
        {
            if(DataAccess.ThemUngVien(mauv, hoten, ngaysinh, diachi, sdt, email, manv))
                return true;
            return false;
        }
    }
}
