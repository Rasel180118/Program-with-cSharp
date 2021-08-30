using System;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0, b = 1, c, number, count = 0;
            Console.WriteLine("Enter a number: ");
            number = int.Parse(Console.ReadLine());
            //count = 0;

            while (count < number)
            {
                c = a + b;
                a = b;
                b = c;
                Console.WriteLine(c);
                count++;
            }
        }
    }
}
