using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM235481_DangKimThao_B3_SimplifyingMethodCalls_RemoveParameter_Before
{
    public class Before
    {
        public double CalculateSalary(double baseSalary, bool unusedParam)
        {
            return baseSalary * 1.2;
        }
    }
}
