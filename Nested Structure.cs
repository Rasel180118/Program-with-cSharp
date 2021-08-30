using System;

namespace Nested_Structure
{
    class Program
    {
        struct employee
        {
            public string Name;
            public dtObirth Date;
        }
        struct dtObirth
        {
            public int Day;
            public int Month;
            public int Year;
        }
        static void Main(string[] args)
        {
            int i, dd = 0, mm = 0, yy = 0;
            int total = 2;
            employee[] emp = new employee[total];

            for (i = 0; i < total; i++)
            {
                Console.WriteLine("Name of the employee: ");
                string name = Console.ReadLine();
                emp[i].Name = name;

                Console.WriteLine("Input day of Birth: ");
                dd = Convert.ToInt32(Console.ReadLine());
                emp[i].Date.Day = dd;

                Console.WriteLine("Input month of Birth: ");
                mm = Convert.ToInt32(Console.ReadLine());
                emp[i].Date.Month = mm;

                Console.WriteLine("Input year of Birth: ");
                yy = Convert.ToInt32(Console.ReadLine());
                emp[i].Date.Day = yy;
            }
        }
    }
}
