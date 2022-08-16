using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz_OOP.Entities
{
    public abstract class BaseType
    {
        public void PrintName()
        {
            Console.WriteLine(this.GetType().Name);
        }
    }
}
