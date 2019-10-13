using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Figure_ClassLibrary;

namespace Figures_ConsoleApp
{
    public delegate double CalculateCircle(double r);

    public delegate double CalculateRectangle(double a, double b);

    public delegate double CalculateTriangle(double c, double h);

    public delegate double CalculateSquare(double d);
      

    class Program
    {
        public static Dictionary<string, Delegate> figure;
        static void Main(string[] args)
        {
            figure = new Dictionary<string, Delegate>()
            {
                { "1", new CalculateCircle(Circle.GetCircleArea) },
                { "2", new CalculateTriangle(Triangle.GetTriangleArea) },
                { "3", new CalculateRectangle(Rectangle.GetRectangleArea) },
                { "4", new CalculateSquare(Square.GetSquareArea) }
            };

            double area, length;
            do
            {
                Console.WriteLine("\nChoose one of the following figures:\n");
                Console.WriteLine("[ 1 ] Circle");
                Console.WriteLine("[ 2 ] Triangle");
                Console.WriteLine("[ 3 ] Rectangle");
                Console.WriteLine("[ 4 ] Square");
                Console.WriteLine("[ 0 ] Exit");
                string command = Console.ReadLine();

                switch (command)
                {
                    case "1":
                        Console.Clear();
                        Console.WriteLine("Enter radius");
                        double r = Convert.ToDouble(Console.ReadLine());

                        CalculateCircle calcCircle = (CalculateCircle)figure[command];
                        area = calcCircle(r);
                        calcCircle = new CalculateCircle(Circle.GetLength);
                        length = calcCircle(r);

                        Console.WriteLine($"Circle area : {area}");
                        Console.WriteLine($"Circle length : {length}");
                        break;

                    case "2":
                        Console.Clear();
                        Console.WriteLine("Enter a");
                        double a = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Enter h");
                        double h = Convert.ToDouble(Console.ReadLine());
                        CalculateTriangle calcTriangle = (CalculateTriangle)figure[command];
                        area = calcTriangle(a, h);
                        Console.WriteLine($"Triangle area : {area}");
                        break;

                    case "3":
                        Console.Clear();
                        Console.WriteLine("Enter a");
                        double c = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Enter b");
                        double b = Convert.ToDouble(Console.ReadLine());
                        CalculateRectangle calcRectangle = (CalculateRectangle)figure[command]; ;
                        area = calcRectangle(c, b);
                        Console.WriteLine($"Rectangle area : {area}");
                        break;

                    case "4":
                        Console.Clear();
                        Console.WriteLine("Enter a");
                        double d = Convert.ToDouble(Console.ReadLine());
                        CalculateSquare calcSquare = (CalculateSquare)figure[command];
                        area = calcSquare(d);
                        Console.WriteLine($"Square area : {area}");
                        break;

                    case "0":
                        Environment.Exit(0);
                        break;
                }
            }
            while (true);
        }
    }
}
