using System;

namespace Convert_upper_to_lower_and_lower_to_upper
{
    class Program
    {
        static void Main(string[] args)
        {
            string str1, str2;
            Console.WriteLine("Enter a string: ");
            str1 = Console.ReadLine();
            str2 = str1.ToLower();
            Console.WriteLine("{0}\n{1}",str1,str2);
        }
    }
}
