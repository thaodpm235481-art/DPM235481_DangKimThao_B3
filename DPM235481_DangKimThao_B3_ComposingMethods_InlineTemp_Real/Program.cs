using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM235481_DangKimThao_B3_ComposingMethods_InlineTemp_Real
{
    public class RealProject
    {
        public bool KiemTraDaiLyCap1(DaiLyNongDuoc daiLy)
        {
            return daiLy.TongDoanhSoNam > 500000000;
        }
    }

    public class DaiLyNongDuoc { public double TongDoanhSoNam { get; set; } }
}
