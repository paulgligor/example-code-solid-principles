using System;
using System.Collections.Generic;
using System.Text;

namespace _2.OpenClosePrinciple.HowTo
{
    public class Circle : Shape
    {
        public double Radius { get; set; }

        public override double Area()
        {
            return Radius * Radius * Math.PI;
        }
    }
}
