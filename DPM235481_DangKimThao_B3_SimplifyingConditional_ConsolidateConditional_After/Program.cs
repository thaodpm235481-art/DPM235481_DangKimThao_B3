using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM235481_DangKimThao_B3_SimplifyingConditional_ConsolidateConditional_After
{
    public class After
    {
        public double DisabilityAmount(int seniority, int monthsDisabled, bool isPartTime)
        {
            if (IsNotEligibleForDisability(seniority, monthsDisabled, isPartTime)) return 0;

            return 100.0;
        }

        private bool IsNotEligibleForDisability(int seniority, int monthsDisabled, bool isPartTime)
        {
            return seniority < 2 || monthsDisabled > 12 || isPartTime;
        }
    }
}
