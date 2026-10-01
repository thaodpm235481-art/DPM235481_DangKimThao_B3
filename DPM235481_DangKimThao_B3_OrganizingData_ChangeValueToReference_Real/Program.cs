using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM235481_DangKimThao_B3_OrganizingData_ChangeValueToReference_Real
{
    public class DanhMucVatTu
    {
        private static readonly Dictionary<string, DanhMucVatTu> CoSoDuLieuVatTu = new Dictionary<string, DanhMucVatTu>();
        public string MaVT { get; }

        private DanhMucVatTu(string maVT) { MaVT = maVT; }

        public static DanhMucVatTu TimKiem(string maVT)
        {
            if (!CoSoDuLieuVatTu.ContainsKey(maVT))
                CoSoDuLieuVatTu[maVT] = new DanhMucVatTu(maVT);
            return CoSoDuLieuVatTu[maVT];
        }
    }

    public class ChiTietKhoAnGiang
    {
        public DanhMucVatTu VatTu { get; set; }
        public ChiTietKhoAnGiang(string maVT)
        {
            VatTu = DanhMucVatTu.TimKiem(maVT);
        }
    }

    public class RealProject { }
}
