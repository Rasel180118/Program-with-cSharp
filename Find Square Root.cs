using System;

namespace Find_Square_Root
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a Number: ");
            int Number = int.Parse(Console.ReadLine());
            double SqrtNumber = Math.Sqrt(Number);
            Console.WriteLine("Square root of " + Number + " is " + SqrtNumber);
        }
    }
}
