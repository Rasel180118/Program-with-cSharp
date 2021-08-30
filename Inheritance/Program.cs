using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangle t1 = new Triangle();
            Triangle t2 = new Triangle();

            t1.Height = 8;
            t1.Width = 10;
            t1.Style = "Left";

            t2.Height = 6;
            t2.Width = 9;
            t2.Style = "Right";

            Console.WriteLine("Info For t1: ");
            t1.ShowDim();
            t1.ShowStyle();
            Console.WriteLine("The area is : "+t1.Area());
            Console.WriteLine();

            Console.WriteLine("Info For t2: ");
            t2.ShowDim();
            t2.ShowStyle();
            Console.WriteLine("Area is : "+t2.Area());
        }
    }
}
