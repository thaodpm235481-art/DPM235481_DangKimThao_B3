using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM235481_DangKimThao_B3_DealingWithGeneralization_FormTemplateMethod_Real
{
    public abstract class QuyTrinhKiemKeKho
    {
        public void ThucHienKiemKe()
        {
            MoSoKhoAnGiang();
            KiemTraSoLuongThucTe();
            DongSoKho();
        }

        private void MoSoKhoAnGiang() => Console.WriteLine("Mở hệ thống quản lý kho An Giang...");
        private void DongSoKho() => Console.WriteLine("Khóa sổ và lưu nhật ký kiểm kê.");

        protected abstract void KiemTraSoLuongThucTe();
    }

    public class KiemKeThuocTruSau : QuyTrinhKiemKeKho
    {
        protected override void KiemTraSoLuongThucTe()
        {
            Console.WriteLine("Đếm số lượng chai thuốc trừ sâu theo lô sản xuất.");
        }
    }

    public class KiemKePhanBon : QuyTrinhKiemKeKho
    {
        protected override void KiemTraSoLuongThucTe()
        {
            Console.WriteLine("Cân tổng trọng lượng các bao phân bón tồn kho.");
        }
    }

    public class RealProject { }
}
