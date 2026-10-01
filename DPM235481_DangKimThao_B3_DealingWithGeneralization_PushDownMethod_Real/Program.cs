using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM235481_DangKimThao_B3_DealingWithGeneralization_PushDownMethod_Real
{
    public class SanPhamChung { }

    public class ThuocSauThuong : SanPhamChung { }

    public class ThuocSauDocCao : SanPhamChung
    {
        public void InCanhBaoCapDoNguyHiem()
        {
            Console.WriteLine("Đặc biệt nguy hiểm - Đọc kỹ hướng dẫn trước khi sử dụng");
        }
    }

    public class RealProject { }
}
