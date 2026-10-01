using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM235481_DangKimThao_B3_MovingFeaturesBetweenObjects_ExtractClass_Real
{
    public class NhanVienThichNghiNongDuoc
    {
        public string HoTen { get; set; }
        public ThongTinLienLac LienHe { get; set; } = new ThongTinLienLac();
    }

    public class ThongTinLienLac
    {
        public string SoDienThoai { get; set; }
        public string DiaChiChiNhanhAnGiang { get; set; }
    }

    public class RealProject { }
}
