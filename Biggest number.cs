using System;

namespace Biggest_number
{
    class Program
    {
        static void Main(string[] args)
        {

            int num1, num2, num3;
            Console.WriteLine("Enter three numbers: ");
            num1 = int.Parse(Console.ReadLine());
            num2= int.Parse(Console.ReadLine());
            num3= int.Parse(Console.ReadLine());

            if (num1 > num2 && num1 > num3)
                Console.WriteLine("Biggest number is: {0}", num1);
            else if (num2 > num1 && num2 > num3)
                Console.WriteLine("Biggest number is: {0}", num2);
            else
                Console.WriteLine("Biggest number is: {0}", num3);
        }
    }
}
