using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM235481_DangKimThao_B3_SimplifyingConditional_DecomposeConditional_After
{
    public class After
    {
        public double GetCharge(DateTime date, double quantity, double summerRate, double winterRate, double winterServiceCharge)
        {
            if (IsNotSummer(date))
                return WinterCharge(quantity, winterRate, winterServiceCharge);
            else
                return SummerCharge(quantity, summerRate);
        }

        private bool IsNotSummer(DateTime date) => date.Month < 6 || date.Month > 8;
        private double WinterCharge(double quantity, double winterRate, double winterServiceCharge) => quantity * winterRate + winterServiceCharge;
        private double SummerCharge(double quantity, double summerRate) => quantity * summerRate;
    }
}
