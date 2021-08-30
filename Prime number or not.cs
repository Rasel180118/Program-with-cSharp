using System;

namespace Prime_number_or_not
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, number, m = 0, count = 0;
            Console.WriteLine("Enter any Number: ");
            number = int.Parse(Console.ReadLine());

            m = number / 2;
            for (i = 2; i <= m; i++)
            {
                if (number % i == 0)
                {
                    Console.WriteLine("Number is not prime.");
                    count = 1;
                    break;
                }
            }
            if (count == 0)
            {
                Console.WriteLine("Number is prime.");
            }
        }
    }
}
