using System;

namespace Addition_of_two_Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j, n;
            int[,] arr1 = new int[3, 3];
            int[,] arr2 = new int[3, 3];
            int[,] arr3 = new int[3, 3];
            Console.WriteLine("Input the size of matrix: ");
            n = int.Parse(Console.ReadLine());

            Console.WriteLine("Input elements in first matrix: ");

            for (i = 0; i < n; i++)
            {
                for (j = 0; j < n; j++)
                {
                    Console.Write("Elements - [{0},{1}] : ",i,j);
                    arr1[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            Console.WriteLine("Input elements in second matrix: ");
            for (i = 0; i < n; i++)
            {
                for (j = 0; j < n; j++)
                {
                    Console.Write("Elements - [{0},{1}] : ",i,j);
                    arr2[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            Console.WriteLine("The first matrix is: ");

            for (i = 0; i < n; i++)
            {
                Console.Write("\n");
                for (j = 0; j < n; j++)
                {
                    Console.Write("{0}\t",arr1[i,j]);
                }
            }

            Console.Write("\nThe second matrix is: \n");

            for (i = 0; i < n; i++)
            {
                Console.Write("\n");
                for (j = 0; j < n; j++)
                {
                    Console.Write("{0}\t", arr2[i, j]);
                }
            }

            for (i = 0; i < n; i++)
            {
                for (j = 0; j < n; j++)
                {
                    arr3[i, j] = arr1[i, j] + arr2[i, j];
                }
            }

            Console.Write("\nThe addition of two matrix is: \n");

            for (i = 0; i < n; i++)
            {
                Console.Write("\n");
                for (j = 0; j < n; j++)
                {
                    Console.Write("{0}\t",arr3[i,j]);
                }
            }
        }
    }
}
