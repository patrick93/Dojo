using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dojo
{
    public class NumberParser
    {
        public static string ParseToRoman(int number)
        {
            Dictionary<int, string> Mapper = new Dictionary<int, string> {
                {1, "I"},
                {5, "V"}
            };
            string result = "";
            for (int i = 0; i < number; i++)
            {
                result += "I";
            }
            return result;
        }
    }
}
