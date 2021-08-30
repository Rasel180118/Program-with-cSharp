using System;

namespace Count_number_of_1s_in_number
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, m, count = 0;
            Console.WriteLine("Enter the limit: ");
            m = int.Parse(Console.ReadLine());

            int[] arr = new int[m];
            Console.WriteLine("Enter the numbers: ");
            for (i = 0; i < m; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            foreach (int value in arr)
            {
                if (value == 1)
                    count++;
            }
            Console.WriteLine("Number of 1's in the entered number: ");
            Console.WriteLine(count);
        }
    }
}
