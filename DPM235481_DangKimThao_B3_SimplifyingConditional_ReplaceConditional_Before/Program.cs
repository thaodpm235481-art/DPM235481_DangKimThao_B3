using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM235481_DangKimThao_B3_SimplifyingConditional_ReplaceConditional_Before
{
    public class Before
    {
        public double GetSpeed(int type, double voltage)
        {
            switch (type)
            {
                case 0: return 100;
                case 1: return voltage * 2;
                default: return 0;
            }
        }
    }
}
