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

            for (int i = 1; i <= 100; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else if (i % 3 != 0 && i % 5 != 0)
                {
                    Console.WriteLine($"{i}");
                }
            };
        }
    }
}
