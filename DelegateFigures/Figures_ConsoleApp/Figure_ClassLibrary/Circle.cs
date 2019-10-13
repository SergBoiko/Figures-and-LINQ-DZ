using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figure_ClassLibrary
{
    public class Circle : Figure
    {
        public static double GetCircleArea(double r)
        {
            double circleArea;
            circleArea = Math.PI * r * r;
            return circleArea;
        }

        public static double GetLength(double r)
        {
            double length;
            length = 2 * Math.PI * r;
            return length;
        }
    }
}
