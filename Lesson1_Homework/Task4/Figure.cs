using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Figure
    {
        Point[] point;
        string type;

        public string Type
        {
            get
            {
                return type;
            }
        }
        public double LengthSide(Point A, Point B)
        {
            return Math.Sqrt(Math.Pow((B.Y-A.Y),2)+Math.Pow((B.X-A.X),2));
        }

        public void CalculatorPerimeter()
        {
            double perimeter = 0;
            for (int i = 0; i < point.Length - 1; i++)
            {
                perimeter += LengthSide(point[i], point[i + 1]);
            }
            perimeter += LengthSide(point[point.Length - 1], point[0]);
            Console.WriteLine(perimeter);
        }
        public Figure(Point p1, Point p2, Point p3)
        {
            point = new Point[3] {p1, p2, p3};
            type = "Triangle";

        }
        public Figure(Point p1, Point p2, Point p3, Point p4)
        {
            point = new Point[4] { p1, p2, p3, p4 };
            type = "Tetragon";
        }
        public Figure(Point p1, Point p2, Point p3, Point p4, Point p5)
        {
            point = new Point[5] { p1, p2, p3, p4, p5 };
            type = "Pentagon";
        }
    }
}
