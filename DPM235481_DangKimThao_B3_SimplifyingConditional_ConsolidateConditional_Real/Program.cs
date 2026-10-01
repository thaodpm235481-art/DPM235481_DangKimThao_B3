using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM235481_DangKimThao_B3_SimplifyingConditional_ConsolidateConditional_Real
{
    public class RealProject
    {
        public double TinhChietKhauKhachHangAnGiang(double doanhSo, bool coNoXau, bool daTrungXau)
        {
            if (KhongDuDieuKienNhanChietKhau(doanhSo, coNoXau, daTrungXau)) return 0;

            return doanhSo * 0.05;
        }

        private bool KhongDuDieuKienNhanChietKhau(double doanhSo, bool coNoXau, bool daTrungXau)
        {
            return doanhSo < 50000000 || coNoXau || daTrungXau;
        }
    }
}
