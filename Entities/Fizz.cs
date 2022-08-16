using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz_OOP.Entities
{
    internal class Fizz : BaseType
    {
        public bool EsDivisiblePor3 { get; set; }


        public Fizz(int value)
        {
            if (value % 3 == 0)
            {
                EsDivisiblePor3 = true;
            }
            else
            {
                EsDivisiblePor3 = false;
            }
        }
    }

}
