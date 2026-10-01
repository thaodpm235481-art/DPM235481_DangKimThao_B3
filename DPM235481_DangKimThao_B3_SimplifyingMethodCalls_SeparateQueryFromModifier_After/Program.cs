using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM235481_DangKimThao_B3_SimplifyingMethodCalls_SeparateQueryFromModifier_After
{
    public class After
    {
        public string FoundPerson(string[] people)
        {
            for (int i = 0; i < people.Length; i++)
            {
                if (people[i] == "Don") return "Don";
            }
            return "";
        }

        public void SendAlert()
        {
            Console.WriteLine("Alert!");
        }
    }
}
