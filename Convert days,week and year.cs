using System;

namespace Convert_days_week_and_year
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, years, days, weeks;
            Console.WriteLine("Enter the number : ");
            n = int.Parse(Console.ReadLine());

            years = n / 365;
            weeks = (n % 365) / 7;
            days = (n % 365) % 7;

            Console.WriteLine("Years: {0}\nWeeks: {1}\nDays: {2}",years,weeks,days);
        }
    }
}
