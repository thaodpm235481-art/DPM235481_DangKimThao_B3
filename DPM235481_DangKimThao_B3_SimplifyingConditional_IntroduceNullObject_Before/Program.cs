using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM235481_DangKimThao_B3_SimplifyingConditional_IntroduceNullObject_Before
{
    public class Customer
    {
        public string Name { get; set; }
    }

    public class Before
    {
        public string GetCustomerName(Customer customer)
        {
            return customer == null ? "occupant" : customer.Name;
        }
    }
}
