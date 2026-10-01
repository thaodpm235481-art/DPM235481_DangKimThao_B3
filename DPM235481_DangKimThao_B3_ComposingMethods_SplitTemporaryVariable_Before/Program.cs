using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM235481_DangKimThao_B3_ComposingMethods_SplitTemporaryVariable_Before
{
    public class Before
    {
        public void Compute(double height, double width)
        {
            double temp = 2 * (height + width);
            Console.WriteLine("Perimeter: " + temp);

            temp = height * width;
            Console.WriteLine("Area: " + temp);
        }
    }
}
