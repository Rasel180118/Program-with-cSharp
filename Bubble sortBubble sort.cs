using System;

namespace Bubble_sort
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, number;
            Console.WriteLine("Enter the number of elements: ");
            number = int.Parse(Console.ReadLine());
            int[] a = new int[10];
            Console.WriteLine("Enter numbers: ");
            for (i = 0; i < number; i++)
            {
                a[i]= Convert.ToInt32(Console.ReadLine());
            }
            Bubble_sort(a, number);
            Console.WriteLine("Ascending order of given number is: ");
            for (i = 0; i < number; i++)
            {
                Console.WriteLine(a[i]);
            }


        }

        private static void Bubble_sort(int[] a, int number)
        {
            int i, j, temp;
            i = number;
            if (i > 0)
            {
                for (j = 0; j < number - 1; j++)
                {
                    if (a[j] > a[j + 1])
                    {
                        temp = a[j];
                        a[j] = a[j + 1];
                        a[j + 1] = temp;
                    }
                }
                Bubble_sort(a, number - 1);
            }
            else
            {
                return;
            }
        }
    }
}
