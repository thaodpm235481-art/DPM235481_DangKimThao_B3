using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM235481_DangKimThao_B3_MovingFeaturesBetweenObjects_MoveField_Before
{
    public class Account
    {
        public AccountType Type { get; set; }
        public double InterestRate { get; set; } // Phụ thuộc vào Type
    }

    public class AccountType { }
    public class Before { }
}
