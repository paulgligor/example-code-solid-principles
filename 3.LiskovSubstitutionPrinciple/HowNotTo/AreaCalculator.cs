using System;
using System.Collections.Generic;
using System.Text;

namespace _3.LiskovSubstitutionPrinciple.HowNotTo
{
    public class AreaCalculator
    {
        public static int CalculateArea(Rectangle r)
        {
            return r.Height * r.Width;
        }

        public static int CalculateArea(Square s)
        {
            return s.Height * s.Height;
        }
    }
}
