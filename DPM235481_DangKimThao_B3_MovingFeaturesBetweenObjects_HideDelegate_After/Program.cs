using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM235481_DangKimThao_B3_MovingFeaturesBetweenObjects_HideDelegate_After
{
    public class Person
    {
        private Department _department;

        public Person(Department department)
        {
            _department = department;
        }

        public Person GetManager() => _department.Manager;
    }

    public class Department
    {
        public Person Manager { get; set; }
    }

    public class After { }
}
