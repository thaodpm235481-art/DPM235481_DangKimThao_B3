using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM235481_DangKimThao_B3_ComposingMethods_ReplaceTempWithQuery_Real
{
    public class RealProject
    {
        private readonly int _soThungPhanBon;
        private readonly double _donGiaThung;

        public RealProject(int soThungPhanBon, double donGiaThung)
        {
            _soThungPhanBon = soThungPhanBon;
            _donGiaThung = donGiaThung;
        }

        public double TinhThanhTienLoHang()
        {
            return TongGiaChuaGiam() * HeSoChietKhauAnGiang();
        }

        private double TongGiaChuaGiam() => _soThungPhanBon * _donGiaThung;

        private double HeSoChietKhauAnGiang() => TongGiaChuaGiam() > 50000000 ? 0.90 : 0.95;
    }
}
