using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM235481_DangKimThao_B3_DealingWithGeneralization_PullUpMethod_Real
{
    public abstract class VatTuNongNghiep
    {
        public void InThongTinThietBi()
        {
            Console.WriteLine("Sản phẩm phân phối bởi Nông Dược An Giang");
        }
    }

    public class ThuocTruBenh : VatTuNongNghiep { }
    public class HatGiongLuu : VatTuNongNghiep { }

    public class RealProject { }
}
