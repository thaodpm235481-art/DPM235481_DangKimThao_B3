using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM235481_DangKimThao_B3_ComposingMethods_InlineMethod_Real
{
    public class RealProject
    {
        public int SoNgayTreHạnDoiNo { get; set; }

        public string XepLoaiTinDungDaiLy()
        {
            return SoNgayTreHạnDoiNo > 30 ? "Nguy cơ nợ xấu" : "Đạt yêu cầu";
        }
    }
}
