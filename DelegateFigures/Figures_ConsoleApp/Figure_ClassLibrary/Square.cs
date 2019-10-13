using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figure_ClassLibrary
{
    public class Square : Figure
    {
        public static double GetSquareArea(double a)
        {
            double squareArea;
            squareArea = a * a;
            return squareArea;
        }
    }
}
