using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM235481_DangKimThao_B3_DealingWithGeneralization_ExtractInterface_Real
{
    public interface IThongKeHoaDon
    {
        double TinhTongTienPhaiTra();
        bool LaDonHangDaiLyAnGiang();
    }

    public class DonHangKhuVuc : IThongKeHoaDon
    {
        public double TinhTongTienPhaiTra() => 15000000;
        public bool LaDonHangDaiLyAnGiang() => true;
    }

    public class RealProject { }
}
