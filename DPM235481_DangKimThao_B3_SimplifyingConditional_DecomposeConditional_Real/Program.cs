using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM235481_DangKimThao_B3_SimplifyingConditional_DecomposeConditional_Real
{
    public class RealProject
    {
        public double TinhGiaBanVatTuTheoMua(DateTime ngayLap, double soLuong, double giaMuaKieuDong, double giaMuaVuHeThu)
        {
            if (LaMienTayVuHeThu(ngayLap))
                return TinhThanhTienVuHeThu(soLuong, giaMuaVuHeThu);
            else
                return TinhThanhTienVuDongXuan(soLuong, giaMuaKieuDong);
        }

        private bool LaMienTayVuHeThu(DateTime ngayLap) => ngayLap.Month >= 5 && ngayLap.Month <= 10;
        private double TinhThanhTienVuHeThu(double qty, double rate) => qty * rate * 0.95; // Giảm giá hỗ trợ mùa lũ
        private double TinhThanhTienVuDongXuan(double qty, double rate) => qty * rate;
    }
}
