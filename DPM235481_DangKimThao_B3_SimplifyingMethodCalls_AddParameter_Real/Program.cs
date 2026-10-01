using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM235481_DangKimThao_B3_SimplifyingMethodCalls_AddParameter_Real
{
    public class RealProject
    {
        public void GuiThongBaoChoDaiLy(string ngayGiaoHangStr, string tenKhuVuc)
        {
            Console.WriteLine($"Gửi lịch giao hàng {ngayGiaoHangStr} đến chi nhánh {tenKhuVuc}");
        }
    }
}
