using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM235481_DangKimThao_B3_OrganizingData_ReplaceArrayWithObject_Real
{
    public class DotGiaoHangNongSan
    {
        public string TenDaiLy { get; set; }
        public int SoThungThuocDungChung { get; set; }
    }

    public class RealProject
    {
        public void TaoGiaoDich()
        {
            DotGiaoHangNongSan dot1 = new DotGiaoHangNongSan
            {
                TenDaiLy = "Đại lý Ba Chúc",
                SoThungThuocDungChung = 120
            };
        }
    }
}
