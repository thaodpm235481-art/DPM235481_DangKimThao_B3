using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM235481_DangKimThao_B3_SimplifyingMethodCalls_SeparateQueryFromModifier_Before
{
    public class Before
    {
        public string CheckAndSendAlert(string[] people)
        {
            for (int i = 0; i < people.Length; i++)
            {
                if (people[i] == "Don")
                {
                    SendAlert();
                    return "Don";
                }
            }
            return "";
        }

        private void SendAlert() => Console.WriteLine("Alert!");
    }
}
