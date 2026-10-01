using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM235481_DangKimThao_B3_OrganizingData_ChangeValueToReference_Before
{
    public class Customer
    {
        public string Name { get; }
        public Customer(string name) { Name = name; }
    }

    public class Order
    {
        public Customer Customer { get; set; }
        public Order(string customerName)
        {
            Customer = new Customer(customerName);
        }
    }

    public class Before { }
}
