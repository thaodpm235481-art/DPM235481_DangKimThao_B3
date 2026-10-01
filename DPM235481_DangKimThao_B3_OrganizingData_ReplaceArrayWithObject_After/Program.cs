using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM235481_DangKimThao_B3_OrganizingData_ReplaceArrayWithObject_After
{
    public class Performance
    {
        public string Name { get; set; }
        public int Wins { get; set; }
    }

    public class After
    {
        public void Process()
        {
            Performance row = new Performance();
            row.Name = "Liverpool";
            row.Wins = 15;
        }
    }
}
