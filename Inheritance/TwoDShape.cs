using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    class TwoDShape
    {
        public double Height { get; set; }
        public double Width { get; set; } 

        public void ShowDim()
        {
            Console.WriteLine("Height and Width are: "+Height+" and "+Width);
        }
    }
}
