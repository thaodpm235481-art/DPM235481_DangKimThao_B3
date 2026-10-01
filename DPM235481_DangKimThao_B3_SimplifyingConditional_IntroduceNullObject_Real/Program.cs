using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM235481_DangKimThao_B3_SimplifyingConditional_IntroduceNullObject_Real
{
    public interface IDaiLyNongDuoc
    {
        string TenDaiLy { get; }
    }

    public class DaiLyHopTac : IDaiLyNongDuoc
    {
        public string TenDaiLy { get; set; }
    }

    public class DaiLyVoDanh : IDaiLyNongDuoc
    {
        public string TenDaiLy => "Đại lý bán lẻ vãng lai";
    }

    public class RealProject
    {
        public string InTenKieuHang(IDaiLyNongDuoc daiLy)
        {
            return daiLy.TenDaiLy;
        }
    }
}
