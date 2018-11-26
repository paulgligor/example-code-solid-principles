using System;
using System.Collections.Generic;
using System.Text;

namespace _4.InterfaceSegregationPrinciple.HowTo
{
    public class Cap : IProduct, IHat
    {
        public int ID { get; set; }
        public double Weight { get; set; }
        public int Stock { get; set; }
        public int HatSize { get; set; }
    }
}
