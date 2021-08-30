using System;

namespace Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, number, factorial = 1;
            Console.WriteLine("Enter a number: ");
            number = int.Parse(Console.ReadLine());

            for (i = 1; i <= number; i++)
            {
                factorial = factorial * i;
            }
            Console.WriteLine(factorial);
        }
    }
}
