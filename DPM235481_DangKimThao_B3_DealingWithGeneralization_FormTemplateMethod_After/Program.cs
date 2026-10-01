using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM235481_DangKimThao_B3_DealingWithGeneralization_FormTemplateMethod_After
{
    public abstract class CaffeineBeverage
    {
        public void PrepareRecipe()
        {
            BoilWater();
            Brew();
            PourInCup();
        }

        private void BoilWater() => Console.WriteLine("Boiling water");
        private void PourInCup() => Console.WriteLine("Pouring in cup");
        protected abstract void Brew();
    }

    public class Tea : CaffeineBeverage
    {
        protected override void Brew() => Console.WriteLine("Steeping tea bag");
    }

    public class Coffee : CaffeineBeverage
    {
        protected override void Brew() => Console.WriteLine("Dripping coffee through filter");
    }

    public class After { }
}
