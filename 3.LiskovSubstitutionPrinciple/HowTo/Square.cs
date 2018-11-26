using System;
using System.Collections.Generic;
using System.Text;

namespace _3.LiskovSubstitutionPrinciple.HowTo
{
    public class Square : Shape
    {
        public int Sides;

        public override int Area()
        {
            return Sides * Sides;
        }

    }
}
