using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    class Triangle : TwoDShape
    {
        public string Style;

        public double Area()
        {
            return 0.5* Height * Width;
        }
        public void ShowStyle()
        {
            Console.WriteLine("Style is: "+Style);
        }
    }
}
