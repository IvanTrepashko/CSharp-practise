using System;

namespace Lect7
{
    class Program
    {
        static void Main(string[] args)
        {
            Task_1();
            Task_2();
            Console.WriteLine();
            Task_3();
        }

        static void Task_1()
        {
            Array array = Array.Empty<Array>();
        }
        static void Task_2()
        {
            object[] arr = new object[3];
            arr[0] = 23;
            arr[1] = 'B';
            arr[2] = "Hello";
            foreach(object item in arr)
                Console.WriteLine(item);
            arr[0] = (int)(arr[0]) + 10;
            arr[2] += ", guys";
            foreach (object item in arr)
                Console.WriteLine(item);
        }
        static void Task_3()
        {
            int[] arr = new int[13];
            Random rnd = new Random();
            for (int i = 0; i < arr.Length; i++)
                arr[i] = rnd.Next(30);
            int max = arr[0];
            foreach (int item in arr)
            {
                if (item > max)
                    max = item;
            }
            foreach (int item in arr)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
            Console.WriteLine(max);
        }
    }
}
