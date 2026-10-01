using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM235481_DangKimThao_B3_Composing_Methods_InlineMethod_Before
{
    public class Before
    {
        public int NumberOfLateDeliveries { get; set; }

        public int GetRating()
        {
            return MoreThanFiveLateDeliveries() ? 2 : 1;
        }

        private bool MoreThanFiveLateDeliveries()
        {
            return NumberOfLateDeliveries > 5;
        }
    }
}
