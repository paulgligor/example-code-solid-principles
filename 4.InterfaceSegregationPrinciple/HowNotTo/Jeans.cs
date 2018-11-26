using System;
using System.Collections.Generic;
using System.Text;

namespace _4.InterfaceSegregationPrinciple.HowNotTo
{
    public class Jeans : IProduct
    {
        public int ID { get; set; }
        public double Weight { get; set; }
        public int Stock { get; set; }
        public int Inseam { get; set; }
        public int WaistSize { get; set; }
    }
}
