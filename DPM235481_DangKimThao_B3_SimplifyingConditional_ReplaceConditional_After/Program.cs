using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM235481_DangKimThao_B3_SimplifyingConditional_ReplaceConditional_After
{
    public abstract class Bird
    {
        public abstract double GetSpeed();
    }

    public class European : Bird
    {
        public override double GetSpeed() => 100;
    }

    public class African : Bird
    {
        private readonly double _voltage;
        public African(double voltage) { _voltage = voltage; }
        public override double GetSpeed() => _voltage * 2;
    }

    public class After { }
}
