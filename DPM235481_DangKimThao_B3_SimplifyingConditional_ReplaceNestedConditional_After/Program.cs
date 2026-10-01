using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM235481_DangKimThao_B3_SimplifyingConditional_ReplaceNestedConditional_After
{
    public class After
    {
        public double GetPayAmount(bool isDead, bool isSeparated, bool isRetired)
        {
            if (isDead) return DeadAmount();
            if (isSeparated) return SeparatedAmount();
            if (isRetired) return RetiredAmount();

            return NormalPayAmount();
        }

        private double DeadAmount() => 100;
        private double SeparatedAmount() => 200;
        private double RetiredAmount() => 300;
        private double NormalPayAmount() => 400;
    }
}
