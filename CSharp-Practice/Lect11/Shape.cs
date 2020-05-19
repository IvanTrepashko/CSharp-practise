using System;
using System.Collections.Generic;
using System.Text;

namespace Lect11
{
    abstract class Shape
    {
        public double Square { get; set; }
        public abstract void CalculateSquare();
        public abstract void ShowInformation();
    }
}
