using System;
using System.Collections.Generic;
using System.Text;

namespace _2.OpenClosePrinciple.HowTo
{
    public class Triangle : Shape
    {
        public double Height { get; set; }
        public double Width { get; set; }

        public override double Area()
        {
            return Height * Width * 0.5;
        }
    }
}
