using System;
using System.Collections;
namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList arrayList = new ArrayList();

            // тип параметра - object 
            arrayList.Add(45); // true,boxing
            arrayList.Add(true); // true, boxing 
            arrayList.Add("Hello!");// false
            arrayList.Add(23.45); //true, boxing


        }
    }
}
