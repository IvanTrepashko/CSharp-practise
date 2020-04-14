using System;
using System.Collections.Generic;
using System.Text;

namespace Lect11
{
    class Triangle : Shape
    {
        public int Side { get; set; }
        public int Height { get; set; }

        public override void CalculateSquare()
        {
            Square = 0.5 * Side * Height;
        }

        public override void ShowInformation()
        {
            Console.WriteLine($"This is a Triangle. CLR Type is {this.GetType()}. Square is {Square}.");
        }

        public Triangle()
        {
            Random rnd = new Random();
            Side = rnd.Next(1, 10);
            Height = rnd.Next(1, 10);
        }
    }
}
