using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM235481_DangKimThao_B3_MovingFeaturesBetweenObjects_MoveField_Real
{
    public class SanPhamNongDuoc
    {
        public NhomThuoc Nhom { get; set; }
        public double ThueVAT => Nhom.ThueVAT;
    }

    public class NhomThuoc
    {
        public string TenNhom { get; set; } // Thuốc trừ sâu, Phân bón lá...
        public double ThueVAT { get; set; }
    }

    public class RealProject { }
}
