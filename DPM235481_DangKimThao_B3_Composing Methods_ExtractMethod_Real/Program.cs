using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM235481_DangKimThao_B3_Composing_Methods_ExtractMethod_Real
{
    public class RealProject
    {
        public void InHoaDonNongDuoc(string tenDaiLy, double tongTien)
        {
            InTieuDeCongTy();
            InChiTietDonHang(tenDaiLy, tongTien);
        }

        private void InTieuDeCongTy()
        {
            Console.WriteLine("=== CÔNG TY CỔ PHẦN NÔNG DƯỢC AN GIANG ===");
            Console.WriteLine("Địa chỉ: TP. Long Xuyên, Tỉnh An Giang");
        }

        private void InChiTietDonHang(string tenDaiLy, double tongTien)
        {
            Console.WriteLine($"Đại lý nhận: {tenDaiLy}");
            Console.WriteLine($"Tổng tiền vật tư: {tongTien:N0} VNĐ");
        }
    }
}
