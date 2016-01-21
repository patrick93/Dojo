using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dojo
{
    public class NumberParser
    {
        private static List<RomanNumber> Mapper = new List<RomanNumber>(){
            new RomanNumber(1, "I"),
            new RomanNumber(4, "IV"),
            new RomanNumber(5, "V"),
            new RomanNumber(9, "IX")
        };

        public static string ParseToRoman(int number)
        {
            if (number < 1)
            {
                throw new ArgumentException();
            }

            string result = "";
            RomanNumber closest = null;
            while (number > 0)
            {
                foreach (RomanNumber item in Mapper)
                {
                    if (item.Number > number)
                    {
                        break;
                    }
                    closest = item;
                }
                result += closest.Roman;
                number -= closest.Number;
            }
            return result;
        }
    }
}
