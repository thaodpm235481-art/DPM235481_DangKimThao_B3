using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM235481_DangKimThao_B3_Composing_Methods_ExtractMethod_After
{
    public class After
    {
        public void PrintInvoice(string customerName, double amount)
        {
            PrintBanner();
            PrintDetails(customerName, amount);
        }

        private void PrintBanner()
        {
            Console.WriteLine("***********************");
            Console.WriteLine("**** Customer Banner ****");
            Console.WriteLine("***********************");
        }

        private void PrintDetails(string customerName, double amount)
        {
            Console.WriteLine("Name: " + customerName);
            Console.WriteLine("Amount: " + amount);
        }
    }
}
