using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM235481_DangKimThao_B3_OrganizingData_ReplaceMagicNumberWithSymbolicConstant_Real
{
    public class RealProject
    {
        private const double ThueGiaTriGiaTangNongNghiep = 0.05;

        public double TinhThueVatVatTu(double thanhTienChuaThue)
        {
            return thanhTienChuaThue * ThueGiaTriGiaTangNongNghiep;
        }
    }
}
