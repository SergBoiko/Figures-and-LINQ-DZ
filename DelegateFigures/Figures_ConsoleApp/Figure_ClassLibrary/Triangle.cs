using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figure_ClassLibrary
{
    public class Triangle : Figure
    {
        public static double GetTriangleArea(double a, double h)
        {
            double triangleArea;
            triangleArea = 0.5 * a * h; 
            return triangleArea;
        }
    }
}
