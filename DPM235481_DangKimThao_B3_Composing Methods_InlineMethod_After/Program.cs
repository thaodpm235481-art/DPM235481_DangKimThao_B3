using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM235481_DangKimThao_B3_Composing_Methods_InlineMethod_After
{
    public class After
    {
        public int NumberOfLateDeliveries { get; set; }

        public int GetRating()
        {
            return NumberOfLateDeliveries > 5 ? 2 : 1;
        }
    }
}
