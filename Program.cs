using FizzBuzz_OOP.Entities;
using System;

namespace FizzBuzz_OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escribir los números del 1 al 100!");
            Console.WriteLine("Cuando sea multiplo de 3 escribir Fizz!");
            Console.WriteLine("Cuando sea multiplo de 5 escribir Buzz!");
            Console.WriteLine("Cuando sea multiplo de 3 y de 5 escribir FizzBuzz!");

            for (int index = 1; index <= 100; index++)
            {
                var fizz = new Fizz(index);
                var buzz = new Buzz(index);

                if (fizz.EsDivisiblePor3 && buzz.EsDivisiblePor5)
                {
                    Console.WriteLine($"{ fizz.GetType().Name}{buzz.GetType().Name}");
                }
                else if (buzz.EsDivisiblePor5)
                {
                    buzz.PrintName();
                }
                else if (fizz.EsDivisiblePor3)
                {
                    fizz.PrintName();
                }
                else
                {
                    Console.WriteLine(index);
                }
            }


            Console.ReadLine();
        }
    }
}
