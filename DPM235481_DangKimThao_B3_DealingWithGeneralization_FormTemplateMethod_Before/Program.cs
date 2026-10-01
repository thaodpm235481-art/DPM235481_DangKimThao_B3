using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM235481_DangKimThao_B3_DealingWithGeneralization_FormTemplateMethod_Before
{
    public class Tea
    {
        public void PrepareRecipe()
        {
            Console.WriteLine("Boiling water");
            Console.WriteLine("Steeping tea bag");
            Console.WriteLine("Pouring in cup");
        }
    }

    public class Coffee
    {
        public void PrepareRecipe()
        {
            Console.WriteLine("Boiling water");
            Console.WriteLine("Dripping coffee through filter");
            Console.WriteLine("Pouring in cup");
        }
    }

    public class Before { }
}
