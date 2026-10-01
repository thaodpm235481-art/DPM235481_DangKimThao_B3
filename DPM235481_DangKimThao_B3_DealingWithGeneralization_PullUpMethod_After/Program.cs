using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM235481_DangKimThao_B3_DealingWithGeneralization_PullUpMethod_After
{
    public abstract class Unit
    {
        public void Attack() => Console.WriteLine("Attacking...");
    }

    public class Soldier : Unit { }
    public class Tank : Unit { }

    public class After { }
}
