using System;

namespace GCD_using_Recursion
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, gcd, lcm, x;
            Console.WriteLine("Enter two number: ");
            num1 = int.Parse(Console.ReadLine());
            num2 = int.Parse(Console.ReadLine());
            int v1 = GetGCD(num1, num2);
            int v = v1;
            gcd = v;
            lcm = (num1 * num2) / gcd;
            Console.WriteLine(gcd);
            Console.WriteLine(lcm);
        }

        private static int GetGCD(int temp1, int temp2)
        {
            if (temp2 != 0)
            {
                GetGCD(temp2, temp1 % temp2);
            }
            else
            {
                return (temp1);
            }
        }
    }
}
