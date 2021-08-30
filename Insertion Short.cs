using System;

namespace Insertion_Short
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, n;
            int[] arr = new int[10];
            Console.WriteLine("Enter the size of array: ");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the elements of array: ");

            for (i = 0; i < n; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Array is: ");

            for (i = 0; i < n; i++)
            {
                Console.WriteLine(arr[i]);
            }

            insertsort(arr, n);
            Console.WriteLine("The Sorted Array is : ");

            for (i = 0; i < n; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }

        private static void insertsort(int[] arr, int n)
        {
            int i, j;
            for (i = 1; i < n; i++)
            {
                int item = arr[i];
                int ins = 0;
                for (j = i - 1; j >= 0 && ins != 1;)
                {
                    if (item < arr[j])
                    {
                        arr[j + 1] = arr[j];
                        j--;
                        arr[j + 1] = item;
                    }
                    else
                    {
                        ins = 1;
                    }
                }
            }
        }
    }
}
