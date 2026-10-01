using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM235481_DangKimThao_B3_ComposingMethods_ExtractVariable_After
{
    public class After
    {
        public double CalculatePrice(int quantity, double itemPrice)
        {
            double basePrice = quantity * itemPrice;
            double quantityDiscount = Math.Max(0, quantity - 500) * itemPrice * 0.05;
            double shippingFee = Math.Min(basePrice * 0.1, 100.0);

            return basePrice - quantityDiscount + shippingFee;
        }
    }
}
