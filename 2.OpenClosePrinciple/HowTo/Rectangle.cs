using System;
using System.Collections.Generic;
using System.Text;

namespace _2.OpenClosePrinciple.HowTo
{
    public class Rectangle : Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public override double Area()
        {
            return Width * Height;
        }
    }
}
