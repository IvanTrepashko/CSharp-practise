using System;
using System.Collections.Generic;
using System.Text;

namespace Lect11
{
    class Circle : Shape
    {
        public int Radius { get; set; }
        public override void CalculateSquare()
        {
            Square = Math.PI * Math.Pow(Radius, 2);
        }

        public override void ShowInformation()
        {
            Console.WriteLine($"This is Circle. CLR Type is {this.GetType()}. Square is {Square:F2}.");
        }

        public Circle()
        {
            Random rnd = new Random();
            Radius = rnd.Next(1,10);
        }
    }
}
