using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM235481_DangKimThao_B3_OrganizingData_EncapsulateField_After
{
    public class After
    {
        private string _name;

        public string Name
        {
            get => _name;
            set => _name = value;
        }
    }
}
