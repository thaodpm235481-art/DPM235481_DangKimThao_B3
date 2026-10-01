using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM235481_DangKimThao_B3_DealingWithGeneralization_PushDownMethod_Before
{
    public class Unit
    {
        public void JetPackFly() => Console.WriteLine("Flying...");
    }

    public class Soldier : Unit { }
    public class JetpackSoldier : Unit { }

    public class Before { }
}
