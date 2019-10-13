using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figure_ClassLibrary
{
    public class Rectangle : Figure
    {
        public static double GetRectangleArea(double a, double b)
        {
            double rectangleArea;
            rectangleArea = a * b;
            return rectangleArea;
        }
    }
}
