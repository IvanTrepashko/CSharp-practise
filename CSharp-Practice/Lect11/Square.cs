using System;
using System.Collections.Generic;
using System.Text;

namespace Lect11
{
    class Square : Shape
    {
        public int Side { get; set; }
        public override void CalculateSquare()
        {
            Square = Math.Pow(Side, 2);

        }

        public override void ShowInformation()
        {
            Console.WriteLine($"This is Square. CLR Type is {this.GetType()}. Square is {Square}.");
        }

        public Square()
        {
            Random rnd = new Random();
            Side = rnd.Next(1, 10);
        }
    }
}
