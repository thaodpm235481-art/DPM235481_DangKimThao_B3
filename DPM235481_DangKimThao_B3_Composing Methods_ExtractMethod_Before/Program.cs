using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM235481_DangKimThao_B3_Composing_Methods_ExtractMethod_Before
{
    public class Before
    {
        public void PrintInvoice(string customerName, double amount)
        {
            Console.WriteLine("***********************");
            Console.WriteLine("**** Customer Banner ****");
            Console.WriteLine("***********************");

            Console.WriteLine("Name: " + customerName);
            Console.WriteLine("Amount: " + amount);
        }
    }
}
