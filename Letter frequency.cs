using System;

namespace Letter_frequency
{
    class Program
    {
        static void Main(string[] args)
        {
            string str;
            int i, j = 0, x;
            int[] count = new int[26];
            Console.WriteLine("Enter a sentence: ");
            str = Console.ReadLine();


            while (str[j] != '\0')
            {
                if (str[j] >= 'a' && str[j] <= 'z')
                {
                    x = str[j] - 'a';
                    count[x]++;
                }
                if (str[j] >= 'A' && str[j] <= 'Z')
                {
                    x = str[j] - 'A';
                    count[x]++;
                }
                j++;
            }
            for (i = 0; i < 26; i++)
            {
                if (count[i] != 0)
                {
                    Console.WriteLine("{0} is used {1} times.",i+'a',count[i]);
                }
            }
        }
    }
}
