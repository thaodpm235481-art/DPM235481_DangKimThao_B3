using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM235481_DangKimThao_B3_OrganizingData_ReplaceMagicNumberWithSymbolicConstant_After
{
    public class After
    {
        private const double GravitationalAcceleration = 9.81;

        public double CalculatePotentialEnergy(double mass, double height)
        {
            return mass * GravitationalAcceleration * height;
        }
    }
}
