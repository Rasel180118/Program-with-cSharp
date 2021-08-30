using System;

namespace Prime_number
{
    class Program
    {
        static void Main(string[] args)
        {
            int number, i, j, count = 0;
            Console.WriteLine("Enter a number: ");
            number = int.Parse(Console.ReadLine());

            for (i = 1; i <= number; i++)
            {
                count = 0;
                for (j = 1; j <= i; j++)
                {
                    if (i % j == 0)
                    {
                        count++;
                    }
                }
                if (count == 2)
                {
                    Console.WriteLine(i);
                } 
            }
        }
    }
}
