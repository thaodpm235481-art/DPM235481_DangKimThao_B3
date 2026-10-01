using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM235481_DangKimThao_B3_ComposingMethods_ReplaceTempWithQuery_Before
{
    public class Before
    {
        public double GetPrice(int quantity, double itemPrice)
        {
            double basePrice = quantity * itemPrice;
            double discountFactor;
            if (basePrice > 1000) discountFactor = 0.95;
            else discountFactor = 0.98;

            return basePrice * discountFactor;
        }
    }
}
