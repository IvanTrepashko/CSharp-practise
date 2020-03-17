using System;

namespace Lect5.LetterA
{
    class Program
    {
        static void Main(string[] args)
        {
            string str;
            int count = 0;
            str = Console.ReadLine();
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == 'a')
                {
                    count++;
                }
            }
            Console.WriteLine("Count of letter 'a' is "+count);
        }
    }
}
