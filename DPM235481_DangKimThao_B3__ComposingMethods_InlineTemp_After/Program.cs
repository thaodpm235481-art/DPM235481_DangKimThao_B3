using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM235481_DangKimThao_B3__ComposingMethods_InlineTemp_After
{
    public class After
    {
        public bool IsDiscountAvailable(Order order)
        {
            return order.BasePrice > 1000;
        }
    }

    public class Order { public double BasePrice { get; set; } }
}
