using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM235481_DangKimThao_B3_OrganizingData_EncapsulateField_Real
{
    public class RealProject
    {
        private string _tenThuocTruSau;

        public string TenThuocTruSau
        {
            get => _tenThuocTruSau;
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                    _tenThuocTruSau = value;
            }
        }
    }
}
