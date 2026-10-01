using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM235481_DangKimThao_B3_SimplifyingMethodCalls_ParameterizeMethod_After
{
    public class After
    {
        public void ElevateSalary(ref double salary, double factor) => salary *= (1 + factor);
    }
}
