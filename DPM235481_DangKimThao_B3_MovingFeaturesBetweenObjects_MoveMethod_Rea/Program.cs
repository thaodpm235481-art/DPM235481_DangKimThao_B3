using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM235481_DangKimThao_B3_MovingFeaturesBetweenObjects_MoveMethod_Rea
{
    public class PhieuGiaoHangNongDuoc
    {
        public LoaiKhachHang ClassKhach { get; set; }
        public double TrongLuongKg { get; set; }

        public double TinhCuocVanChuyen()
        {
            return ClassKhach.TinhCuoc(TrongLuongKg);
        }
    }

    public class LoaiKhachHang
    {
        public bool LaDaiLyThanThiet { get; set; }

        public double TinhCuoc(double trongLuongKg)
        {
            double giaCoBan = trongLuongKg * 5000;
            return LaDaiLyThanThiet ? giaCoBan * 0.8 : giaCoBan;
        }
    }

    public class RealProject { }
}
