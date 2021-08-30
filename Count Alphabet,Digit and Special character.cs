using System;

namespace Count_Alphabet_Digit_and_Special_character
{
    class Program
    {
        static void Main(string[] args)
        {
            string str;
            int i, len, Alphabet, Digit, SpecialCharacter;
            Alphabet = Digit = SpecialCharacter = 0;
            Console.WriteLine("Enter any string: ");
            str = Console.ReadLine();
            len = str.Length;
            for (i = 0; i < len; i++)
            {
                if ((str[i] >= 'a' && str[i] <= 'z') || (str[i] >= 'A' && str[i] <= 'Z'))
                {
                    Alphabet++;
                }
                else if (str[i] >= '0' && str[i] <= '9')
                {
                    Digit++;
                }
                else
                    SpecialCharacter++;
            }
            Console.WriteLine("The number of Alphabet is : {0}",Alphabet);
            Console.WriteLine("The number of Digit is : {0}", Digit);
            Console.WriteLine("The number of Special Character is : {0}", SpecialCharacter);

        }
    }
}
