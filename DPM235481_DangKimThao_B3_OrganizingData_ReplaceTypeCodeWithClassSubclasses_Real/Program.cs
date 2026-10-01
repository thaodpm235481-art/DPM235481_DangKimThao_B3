using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM235481_DangKimThao_B3_OrganizingData_ReplaceTypeCodeWithClassSubclasses_Real
{
    public abstract class ThuocBaoVeThucVat
    {
        public abstract string LayDocTinh();
    }

    public class ThuocTruSau : ThuocBaoVeThucVat
    {
        public override string LayDocTinh() => "Độc tính cao - Cần trang bị bảo hộ";
    }

    public class PhanBonLa : ThuocBaoVeThucVat
    {
        public override string LayDocTinh() => "An toàn cho sinh thái";
    }

    public class RealProject { }
}
