using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM235481_DangKimThao_B3_MovingFeaturesBetweenObjects_HideDelegate_Real
{
    public class KhachHangDaiLy
    {
        private KhuVucQuanLy _khuVuc;

        public KhachHangDaiLy(KhuVucQuanLy khuVuc)
        {
            _khuVuc = khuVuc;
        }

        public string LayTenGiamSatVien() => _khuVuc.GiamSatVienChuyenTrach;
    }

    public class KhuVucQuanLy
    {
        public string GiamSatVienChuyenTrach { get; set; }
    }

    public class RealProject { }
}
