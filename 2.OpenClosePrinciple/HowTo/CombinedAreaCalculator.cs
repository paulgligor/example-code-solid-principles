using System;
using System.Collections.Generic;
using System.Text;

namespace _2.OpenClosePrinciple.HowTo
{
    public class CombinedAreaCalculator
    {
        public double Area(Shape[] shapes)
        {
            double area = 0;
            foreach (var shape in shapes)
            {
                area += shape.Area();
            }
            return area;
        }
    }
}
