using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM235481_DangKimThao_B3_SimplifyingMethodCalls_ParameterizeMethod_Before
{
    public class Before
    {
        public void ElevateTenPercent(ref double salary) => salary *= 1.10;
        public void ElevateFivePercent(ref double salary) => salary *= 1.05;
    }
}
