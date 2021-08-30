using System;

namespace Count_the_number_of_word
{
    class Program
    {
        static void Main(string[] args)
        {
            string str;
            int i, len, count = 0;
            Console.WriteLine("Enter any string: ");
            str = Console.ReadLine();
            len = str.Length;

            for (i = 0; i < len; i++)
            {
                count++;
            }
            Console.WriteLine("The number of words are: {0} ",count);
        }
    }
}
