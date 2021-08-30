using System;

namespace Add_two_Dates
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime StartDate = new DateTime(2000, 03, 29);
            Console.WriteLine("Starting Date : "+StartDate);
            DateTime EndDate = StartDate.AddDays(10);
            Console.WriteLine("Ending Date : "+EndDate);
        }
    }
}
