using System;

namespace Lect11
{
    class Program
    {
        static void Main(string[] args)
        {
            Shape[] shapes = new Shape[3];

            Circle circle = new Circle();
            Square square = new Square();
            Triangle triangle = new Triangle();

            shapes[0] = circle;
            shapes[1] = square;
            shapes[2] = triangle;

            foreach(Shape shape in shapes)
            {
                shape.CalculateSquare();
                shape.ShowInformation();
            }
        }
    }
}
