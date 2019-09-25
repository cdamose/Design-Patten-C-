using System;
using System.Collections.Generic;
using System.Text;

namespace Factory.FactoryMethod
{
    public class Point
    {
        double _x, _y;
        public Point(double x, double y)
        {
            _x = x;
            _y = y;
        }
        public static Point NewCatresionPoint(double x, double y)
        {
            return new Point(x, y);
        }

        public static Point NewPolarPoint(double x, double y)
        {
            return new Point(x * Math.Cos(x), y * Math.Tan(y));
        }
    }
    class test
    {
        void main()
        {
            Point p = Point.NewCatresionPoint(45, 6);
        }
    }
}
