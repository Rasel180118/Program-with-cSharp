using System;

namespace Count_the_no_of_Vowel
{
    class Program
    {
        static void Main(string[] args)
        {
            string str;
            int i, len, vowel = 0, consonent = 0;
            Console.WriteLine("Enter any String: ");
            str = Console.ReadLine();
            len = str.Length;

            for (i = 0; i < len; i++)
            {
                if (str[i] == 'A' || str[i] == 'E' || str[i] == 'I' || str[i] == 'O' || str[i] == 'U')
                {
                    vowel++;
                }
                else if (str[i] == 'a' || str[i] == 'e' || str[i] == 'i' || str[i] == 'o' || str[i] == 'u')
                {
                    vowel++;
                }
                else
                    consonent++;
            }
            Console.WriteLine("The numbers of vowel are: {0}",vowel);
            Console.WriteLine("The numbers of consonent are: {0}", consonent);
        }
    }
}
