using System;

namespace Count_spaces_in_string
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, len, count = 0;
            string str;
            Console.WriteLine("Enter any string: ");
            str = Console.ReadLine();
            len = str.Length;

            for (i = 0; i < len; i++)
            {
                if (str[i] == ' ')
                {
                    count++;
                }
            }
            Console.WriteLine(count);
        }
    }
}
