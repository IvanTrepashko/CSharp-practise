using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            short x = 10;
            object obj_short;
            obj_short = x;
            sbyte y = (sbyte)(short)obj_short;
            Console.WriteLine(y);
            Console.WriteLine(y.GetType());
        }
    }
}
