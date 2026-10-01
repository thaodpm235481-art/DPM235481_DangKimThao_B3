using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM235481_DangKimThao_B3_SimplifyingConditional_ReplaceConditional_Real
{
    public abstract class ChietKhauNongSan
    {
        public abstract double TinhGiamGia(double tongTien);
    }

    public class ChietKhauVip : ChietKhauNongSan
    {
        public override double TinhGiamGia(double tongTien) => tongTien * 0.15;
    }

    public class ChietKhauThuong : ChietKhauNongSan
    {
        public override double TinhGiamGia(double tongTien) => tongTien * 0.05;
    }

    public class RealProject { }
}
