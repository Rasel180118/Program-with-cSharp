using System;

namespace Armstrong_number
{
    class Program
    {
        static void Main(string[] args)
        {
            int number, x, temp, sum = 0;
            Console.WriteLine("Enter any number: ");
            number = int.Parse(Console.ReadLine());
            temp = number;

            while (number > 0)
            {
                x = number % 10;
                sum = sum + x * x * x;
                number = number / 10;
            }
            if (sum == temp)
                Console.WriteLine("The {0} is armstrong",temp);
            else
                Console.WriteLine("The {0} is not armstrong",temp);


        }
    }
}
