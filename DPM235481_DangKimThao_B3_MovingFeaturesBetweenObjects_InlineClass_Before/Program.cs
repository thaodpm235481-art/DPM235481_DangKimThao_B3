using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM235481_DangKimThao_B3_MovingFeaturesBetweenObjects_InlineClass_Before
{
    public class Person
    {
        public string Name { get; set; }
        public TelephoneNumber OfficeTelephone { get; set; } = new TelephoneNumber();
    }

    public class TelephoneNumber
    {
        public string Number { get; set; }
    }

    public class Before { }
}
