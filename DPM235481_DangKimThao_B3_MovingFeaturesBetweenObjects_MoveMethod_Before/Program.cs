using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM235481_DangKimThao_B3_MovingFeaturesBetweenObjects_MoveMethod_Before
{
    public class Account
    {
        public AccountType Type { get; set; }
        public int DaysOverdrawn { get; set; }

        public double BankCharge()
        {
            double result = 4.5;
            if (DaysOverdrawn > 0) result += OverdraftCharge();
            return result;
        }

        public double OverdraftCharge()
        {
            if (Type.IsPremium)
            {
                double result = 10;
                if (DaysOverdrawn > 7) result += (DaysOverdrawn - 7) * 0.85;
                return result;
            }
            return DaysOverdrawn * 1.75;
        }
    }

    public class AccountType { public bool IsPremium { get; set; } }
    public class Before { }
}
