using System;

namespace Palindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            int number, reverse = 0, x;
            Console.WriteLine("Enter any Number: ");
            number = int.Parse(Console.ReadLine());
            while(number>0)
            {
                x = number % 10;
                reverse = reverse * 10 + x;
                number = number / 10;
            }
            if(reverse==number)
                Console.WriteLine("palindrome");
        }
    }
}
