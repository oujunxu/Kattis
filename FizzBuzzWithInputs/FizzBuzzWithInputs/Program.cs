using System;

namespace FizzBuzzWithInputs
{
    class Program
    {
        static void Main(string[] args)
        {
            string num = Console.ReadLine();
            string[] numbers = num.Split(" ");

            int a = int.Parse(numbers[0]);
            int b = int.Parse(numbers[1]);
            int n = int.Parse(numbers[2]);

            for(var i = 1; i<=n; i++)
            {
                // if the number is divisible by a and b, FizzBuzz will be printed.
                if ((i % a == 0) && (i % b == 0))
                {
                    Console.WriteLine("FizzBuzz");
                }

                // if the number is divisible by a, Fizz will be printed.
                else if (i % a == 0)
                {
                    Console.WriteLine("Fizz");
                }

                // if the number is divisible by b, Buzz will be printed.
                else if (i % b == 0)
                {
                    Console.WriteLine("Buzz");
                }

                // if nothing above is met then only the number will be printed.
                else
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
