using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM235481_DangKimThao_B3_OrganizingData_ReplaceTypeCodeWithClassSubclasses_Before
{
    public class Employee
    {
        public const int Engineer = 0;
        public const int Manager = 1;
        public int Type { get; set; }
    }

    public class Before { }
}
