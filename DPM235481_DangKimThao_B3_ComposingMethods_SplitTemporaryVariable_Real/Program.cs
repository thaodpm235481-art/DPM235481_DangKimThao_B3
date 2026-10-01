using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM235481_DangKimThao_B3_ComposingMethods_SplitTemporaryVariable_Real
{
    public class RealProject
    {
        public void TinhThuocTruSauChoKhungRuong(double chieuDaiMet, double chieuRongMet)
        {
            double chuViRuong = 2 * (chieuDaiMet + chieuRongMet);
            Console.WriteLine($"Đường biên phun rào: {chuViRuong} m");

            double dienTichRuongM2 = chieuDaiMet * chieuRongMet;
            Console.WriteLine($"Diện tích phun đại trà: {dienTichRuongM2} m2");
        }
    }
}
