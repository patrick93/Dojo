using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dojo
{
    public class RomanNumber
    {
        public int Number { get; set; }
        public string Roman { get; set; }

        public RomanNumber(int number, string roman)
        {
            Number = number;
            Roman = roman;
        }
    }
}
