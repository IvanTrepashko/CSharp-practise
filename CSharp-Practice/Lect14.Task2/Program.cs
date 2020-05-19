using System;
using System.Collections.Generic;
namespace Lect14.Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Neighbor> floorNeighbours = new List<Neighbor>()
            {
                new Neighbor("Ivan Ivanov",10,"64-49-60"),
                new Neighbor("Petr Petrov",11,"40-10-50"),
                new Neighbor("Dmitry Dmitriev",12,"10-60-54"),
                new Neighbor("Anton Antonov",13,"50-35-23"),
                new Neighbor("Alexei Alexeev",14,"53-59-12")
            };

            Console.WriteLine("Enter a number of a flat");
            int.TryParse(Console.ReadLine(), out int number);

            Neighbor neighbor = floorNeighbours.Find(n => n.FlatNumber == number);

            if (neighbor == null) Console.WriteLine("There is no neighbor with such flat number");
            else neighbor.ShowInfo();

        }
    }
}
