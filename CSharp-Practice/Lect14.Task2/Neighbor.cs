using System;
using System.Collections.Generic;
using System.Text;

namespace Lect14.Task2
{
    public class Neighbor
    {
        public string FullName { get; set; }
        public int FlatNumber { get; set; }
        public string PhoneNumber { get; set; }
        public Neighbor(string name,int flatNumber,string phoneNumber)
        {
            FullName = name;
            FlatNumber = flatNumber;
            PhoneNumber = phoneNumber;
        }
        public void ShowInfo()
        {
            Console.WriteLine($"Name of the neighbor is {FullName}.\nPhone number is {PhoneNumber}.");
        }
    }
}
