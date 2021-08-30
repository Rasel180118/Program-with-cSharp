using System;

namespace Get_ASCII_Value
{
    class Program
    {
        static void Main(string[] args)
        {
            char x;
            Console.WriteLine("Enter any character: ");
            x = char.Parse(Console.ReadLine());
            Console.WriteLine("The ASCII value of " + x + " is " + (int)x);
        }
    }
}
