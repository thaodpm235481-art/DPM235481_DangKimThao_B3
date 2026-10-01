using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM235481_DangKimThao_B3_MovingFeaturesBetweenObjects_HideDelegate_Before
{
    public class Person
    {
        public Department Department { get; set; }
    }

    public class Department
    {
        public Person Manager { get; set; }
    }

    public class Before
    {
        public void Demo(Person john)
        {
            Person manager = john.Department.Manager;
        }
    }
}
