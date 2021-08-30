using System;

namespace Cube_Root
{
    class Program
    {
        static void Main(string[] args)
        {
            double number, result;
            Console.WriteLine("Enter a Number: ");
            number = double.Parse(Console.ReadLine());
            result = Math.Ceiling(Math.Pow(number, (double)1 / 3));

            Console.WriteLine("Cube root : {0}",result);
        }
    }
}
