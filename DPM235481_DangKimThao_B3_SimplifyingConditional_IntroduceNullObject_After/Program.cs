using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM235481_DangKimThao_B3_SimplifyingConditional_IntroduceNullObject_After
{
    public interface ICustomer
    {
        string Name { get; }
    }

    public class RealCustomer : ICustomer
    {
        public string Name { get; set; }
    }

    public class NullCustomer : ICustomer
    {
        public string Name => "occupant";
    }

    public class After
    {
        public string GetCustomerName(ICustomer customer)
        {
            return customer.Name;
        }
    }
}
