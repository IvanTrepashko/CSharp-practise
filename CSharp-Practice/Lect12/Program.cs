using System;

namespace Lect12
{
    class Program
    {
        static void Main(string[] args)
        {
            UniqueItem unique = new UniqueItem();
            Console.WriteLine(unique.Id);
            UniqueItem.SetStartID(10);
            UniqueItem unique1 = new UniqueItem();
            Console.WriteLine(unique1.Id);
        }
    }
}
