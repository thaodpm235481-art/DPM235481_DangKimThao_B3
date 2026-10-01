using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM235481_DangKimThao_B3_SimplifyingConditional_DecomposeConditional_Before
{
    public class Before
    {
        public double GetCharge(DateTime date, double quantity, double summerRate, double winterRate, double winterServiceCharge)
        {
            if (date.Month < 6 || date.Month > 8)
                return quantity * winterRate + winterServiceCharge;
            else
                return quantity * summerRate;
        }
    }
}
