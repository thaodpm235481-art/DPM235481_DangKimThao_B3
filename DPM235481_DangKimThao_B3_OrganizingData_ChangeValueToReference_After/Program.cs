using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM235481_DangKimThao_B3_OrganizingData_ChangeValueToReference_After
{
    public class Customer
    {
        private static readonly Dictionary<string, Customer> Instances = new Dictionary<string, Customer>();
        public string Name { get; }

        private Customer(string name) { Name = name; }

        public static Customer Get(string name)
        {
            if (!Instances.ContainsKey(name))
                Instances[name] = new Customer(name);
            return Instances[name];
        }
    }

    public class Order
    {
        public Customer Customer { get; set; }
        public Order(string customerName)
        {
            Customer = Customer.Get(customerName);
        }
    }

    public class After { }
}
