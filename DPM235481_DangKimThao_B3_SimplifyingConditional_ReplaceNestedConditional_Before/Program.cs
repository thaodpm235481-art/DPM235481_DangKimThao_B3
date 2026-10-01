using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM235481_DangKimThao_B3_SimplifyingConditional_ReplaceNestedConditional_Before
{
    public class Before
    {
        public double GetPayAmount(bool isDead, bool isSeparated, bool isRetired)
        {
            double result;
            if (isDead) result = DeadAmount();
            else
            {
                if (isSeparated) result = SeparatedAmount();
                else
                {
                    if (isRetired) result = RetiredAmount();
                    else result = NormalPayAmount();
                }
            }
            return result;
        }

        private double DeadAmount() => 100;
        private double SeparatedAmount() => 200;
        private double RetiredAmount() => 300;
        private double NormalPayAmount() => 400;
    }
}
