using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM235481_DangKimThao_B3_ComposingMethods_ExtractVariable_Real
{
    public class RealProject
    {
        public double TinhTienThuocBaoVeThucVat(int soLuu, double donGiaThuoc)
        {
            double giaGoc = soLuu * donGiaThuoc;
            double chietKhauDaiLyKhuyenMai = Math.Max(0, soLuu - 100) * donGiaThuoc * 0.08;
            double phiVanChuyenMienTay = Math.Min(giaGoc * 0.02, 500000);

            return giaGoc - chietKhauDaiLyKhuyenMai + phiVanChuyenMienTay;
        }
    }
}
