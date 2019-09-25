using Factory.FactoryMethod;
using System;
using System.Collections.Generic;
using System.Text;

namespace Factory.Factory
{
    public class PointFactory
    {
        public static Point NewCatresionPoint(double x, double y)
        {
            return new Point(x, y);
        }

        public static Point NewPolarPoint(double x, double y)
        {
            return new Point(x * Math.Cos(x), y * Math.Tan(y));
        }

    }
}
