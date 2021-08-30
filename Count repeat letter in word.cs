using System;

namespace Count_repeat_letter_in_word
{
    class Program
    {
        static void Main(string[] args)
        {
            string str;
            char c;
            int i, len, count = 0;
            Console.WriteLine("Enter a sentence: ");
            str = Console.ReadLine();
            Console.WriteLine("Enter the character it's repeated: ");
            c = char.Parse(Console.ReadLine());
            len = str.Length;

            for (i = 0; i < len; i++)
            {
                if (str[i] == c)
                {
                    count++;
                }
            }
            Console.WriteLine("Letter {0} repeated {1} times.",c,count);
        }
    }
}
