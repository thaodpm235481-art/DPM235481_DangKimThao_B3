using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM235481_DangKimThao_B3_MovingFeaturesBetweenObjects_MoveField_After
{
    public class Account
    {
        public AccountType Type { get; set; }
        public double InterestRate => Type.InterestRate;
    }

    public class AccountType
    {
        public double InterestRate { get; set; }
    }

    public class After { }
}
