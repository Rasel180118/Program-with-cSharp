using System;

namespace Leep_year
{
    class Program
    {
        static void Main(string[] args)
        {
            int year;
            Console.WriteLine("Enter any year: ");
            year = int.Parse(Console.ReadLine());
            if(year%4==0||year%100==0||year%400==0)
                Console.WriteLine("Leap year");
            else
                Console.WriteLine("Not leap year");
        }
    }
}
