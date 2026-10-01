using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM235481_DangKimThao_B3_DealingWithGeneralization_ExtractInterface_After
{
    public interface IBillable
    {
        double GetRate();
        bool HasSpecialSkill();
    }

    public class Employee : IBillable
    {
        public double GetRate() => 100.0;
        public bool HasSpecialSkill() => true;
    }

    public class After { }
}
