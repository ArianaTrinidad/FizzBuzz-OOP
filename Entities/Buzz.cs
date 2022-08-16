using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz_OOP.Entities
{
    internal class Buzz : BaseType
    {
        public bool EsDivisiblePor5 { get; set; }

        public Buzz(int value)
        {
            if (value % 5 == 0)
            {
                EsDivisiblePor5 = true;
            }
            else
            {
                EsDivisiblePor5 = false;
            }
        }
    }

}
