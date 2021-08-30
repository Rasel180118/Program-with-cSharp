using System;

namespace Conver_lower_to_upper
{
    class Program
    {
        static void Main(string[] args)
        {
            string str1, str2;
            Console.WriteLine("Enter a string: ");
            str1 = Console.ReadLine();
            str2 = str1.ToUpper();
            Console.WriteLine("{0}",str2);
        }
    }
}
