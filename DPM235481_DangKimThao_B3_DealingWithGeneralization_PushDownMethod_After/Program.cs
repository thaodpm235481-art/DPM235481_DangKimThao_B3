using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM235481_DangKimThao_B3_DealingWithGeneralization_PushDownMethod_After
{
    public class Unit { }

    public class Soldier : Unit { }

    public class JetpackSoldier : Unit
    {
        public void JetPackFly() => Console.WriteLine("Flying...");
    }

    public class After { }
}
