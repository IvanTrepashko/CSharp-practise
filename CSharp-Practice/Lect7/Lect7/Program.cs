using System;

namespace Lect7
{
    class Program
    {
        static void Main(string[] args)
        {
            task_2();
        }

        static  void task_2()
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
    }
}
