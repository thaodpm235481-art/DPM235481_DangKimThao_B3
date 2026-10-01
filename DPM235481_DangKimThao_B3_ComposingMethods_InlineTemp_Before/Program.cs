using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM235481_DangKimThao_B3_ComposingMethods_InlineTemp_Before
{
    public class Before
    {
        public bool IsDiscountAvailable(Order order)
        {
            double basePrice = order.BasePrice;
            return basePrice > 1000;
        }
    }

    public class Order { public double BasePrice { get; set; } }
}
