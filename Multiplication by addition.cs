using System;

namespace Multiplication_by_addition
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, i, multiplication = 0;
            Console.WriteLine("Enter two number: ");
            a = int.Parse(Console.ReadLine());
            b= int.Parse(Console.ReadLine());
            
            if(b<0)
            {
                a = a + b;
                b = a - b;
                a = a - b;
            }
            if(a>=0)
            {
                for (i = 1; i <= a; i++)
                    multiplication = multiplication + b;
            }
            if(a<0)
            {
                for (i = a; i <= -1; i++)
                    multiplication = multiplication - b;
            }
            Console.WriteLine("Multiplication: {0}",multiplication);
        }
    }
}
