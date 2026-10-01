using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM235481_DangKimThao_B3_SimplifyingMethodCalls_SeparateQueryFromModifier_Real
{
    public class RealProject
    {
        public bool KiemTraThuocHetHan(string[] danhSachHSD)
        {
            foreach (var hsd in danhSachHSD)
            {
                if (hsd == "HET_HAN") return true;
            }
            return false;
        }

        public void PhatCanhBaoTieuHuy()
        {
            Console.WriteLine("Cảnh báo: Phát hiện lô thuốc bảo vệ thực vật hết hạn!");
        }
    }
}
