using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM235481_DangKimThao_B3_OrganizingData_ReplaceTypeCodeWithClassSubclasses_After
{
    public abstract class Employee
    {
        public abstract int GetTypeCode();
    }

    public class Engineer : Employee
    {
        public override int GetTypeCode() => 0;
    }

    public class Manager : Employee
    {
        public override int GetTypeCode() => 1;
    }

    public class After { }
}
