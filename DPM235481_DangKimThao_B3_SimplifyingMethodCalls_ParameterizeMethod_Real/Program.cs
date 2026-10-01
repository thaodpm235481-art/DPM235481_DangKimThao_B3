using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM235481_DangKimThao_B3_SimplifyingMethodCalls_ParameterizeMethod_Real
{
    public class RealProject
    {
        public void TangGiaVatTuNongNghiep(ref double donGia, double tyLeTang)
        {
            donGia *= (1 + tyLeTang);
        }
    }
}
