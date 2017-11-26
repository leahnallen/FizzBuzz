using System;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 1;
            while (number < 100)
            {
                if (number % 3 == 0 && number % 5 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                    Console.WriteLine("This is a second FizzBuzz.");
                }
                else if (number % 3 == 0) Console.WriteLine("Fizz");
                else if (number % 5 == 0) Console.WriteLine("Buzz");
                else Console.WriteLine(number);

                number++;
            }
        }

    }
}
