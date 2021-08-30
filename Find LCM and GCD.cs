using System;

namespace Find_LCM_and_GCD
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, num1, num2, temp, lcm, gcd;
            Console.WriteLine("Enter two numbers: ");
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());

            num1 = a;
            num2 = b;
            while (num2 != 0)
            {
                temp = num2;
                num2 = num1 % num2;
                num1 = temp;
            }
            gcd = num1;
            lcm = (a * b) / gcd;
            Console.WriteLine("LCM for {0} and {1} is {2}",a,b,lcm);
            Console.WriteLine("GCD for {0} and {1} is {2}",a,b,gcd);
        }
    }
}
