using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM235481_DangKimThao_B3_SimplifyingConditional_ReplaceNestedConditional_Real
{
    public class RealProject
    {
        public double TinhPhiLuuKhoThucTe(bool khoBiKhoa, bool laHangCongKenh, bool laHoaChatDocHai)
        {
            if (khoBiKhoa) return 0;
            if (laHoaChatDocHai) return 500000;
            if (laHangCongKenh) return 300000;

            return 100000; // Phí tiêu chuẩn
        }
    }
}
