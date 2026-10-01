using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM235481_DangKimThao_B3_MovingFeaturesBetweenObjects_MoveMethod_After
{
    public class Account
    {
        public AccountType Type { get; set; }
        public int DaysOverdrawn { get; set; }

        public double BankCharge()
        {
            double result = 4.5;
            if (DaysOverdrawn > 0) result += Type.OverdraftCharge(DaysOverdrawn);
            return result;
        }
    }

    public class AccountType
    {
        public bool IsPremium { get; set; }

        public double OverdraftCharge(int daysOverdrawn)
        {
            if (IsPremium)
            {
                double result = 10;
                if (daysOverdrawn > 7) result += (daysOverdrawn - 7) * 0.85;
                return result;
            }
            return daysOverdrawn * 1.75;
        }
    }

    public class After { }
}
