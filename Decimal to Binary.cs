using System;

namespace Decimal_to_Binary
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, number;
            int[] arr = new int[10];
            Console.WriteLine("Enter the number to convert: ");
            number = int.Parse(Console.ReadLine());

            for (i = 0; number > 0; i++)
            {
                arr[i] = number % 2;
                number = number / 2;
            }
            Console.WriteLine("Binary of the given number: ");
            for (i = i - 1; i >= 0; i--)
            {
                Console.Write(arr[i]);
            }
        }
    }
}
