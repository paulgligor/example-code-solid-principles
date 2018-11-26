using System;
using System.Collections.Generic;
using System.Text;

namespace _4.InterfaceSegregationPrinciple.HowTo
{
    public interface IProduct
    {
        int ID { get; set; }
        double Weight { get; set; }
        int Stock { get; set; }
    }
}
