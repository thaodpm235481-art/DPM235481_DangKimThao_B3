using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM235481_DangKimThao_B3_ComposingMethods_ExtractVariable_Before
{
    public class Before
    {
        public double CalculatePrice(int quantity, double itemPrice)
        {
            return quantity * itemPrice - Math.Max(0, quantity - 500) * itemPrice * 0.05 + Math.Min(quantity * itemPrice * 0.1, 100.0);
        }
    }
}
