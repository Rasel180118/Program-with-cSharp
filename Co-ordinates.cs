using System;

namespace Co_ordinates
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y;
            Console.WriteLine("Enter two number: ");
            x = int.Parse(Console.ReadLine());
            y = int.Parse(Console.ReadLine());

            if (x > 0 && y > 0)
                Console.WriteLine("Co-ordinates ({0},{1}) lies in First quadrant", x, y);
            else if (x < 0 && y > 0)
                Console.WriteLine("Co-ordinates ({0},{1}) lies in Second quadrant", x, y);
            else if (x < 0 && y < 0)
                Console.WriteLine("Co-ordinates ({0},{1}) lies in Third quadrant", x, y);
            else
                Console.WriteLine("Co-ordinates ({0},{1}) lies in Fourth quadrant", x, y);
        }
    }
}
