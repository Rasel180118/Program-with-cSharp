using System;

namespace Find_Position_of_Substring
{
    class Program
    {
        static void Main(string[] args)
        {
            string str1, findstring;
            int index;
            Console.WriteLine("Input a string: ");
            str1 = Console.ReadLine();
            Console.WriteLine("Input a Substring: ");
            findstring = Console.ReadLine();

            index = str1.IndexOf(findstring);
            if (index < 0)
                Console.WriteLine("The substring not Founded");
            else
                Console.WriteLine("Index of " + findstring + " is " + index);
        }
    }
}
