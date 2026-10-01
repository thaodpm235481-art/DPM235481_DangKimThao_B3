using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM235481_DangKimThao_B3_ComposingMethods_ReplaceTempWithQuery_After
{
    public class After
    {
        private readonly int _quantity;
        private readonly double _itemPrice;

        public After(int quantity, double itemPrice)
        {
            _quantity = quantity;
            _itemPrice = itemPrice;
        }

        public double GetPrice()
        {
            return BasePrice() * DiscountFactor();
        }

        private double BasePrice() => _quantity * _itemPrice;

        private double DiscountFactor() => BasePrice() > 1000 ? 0.95 : 0.98;
    }
}
