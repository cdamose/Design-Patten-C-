using Factory.WithoutFactoryLife.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace Factory.InnerFactory.way1
{
   public class point
    {
        private double _x,_y;
        internal point(double x,double y)
        {
            _x = x;
            _y = y;
        }
       
       public static class Factory
        {
            public static point NewCatresionPoint(double x, double y)
            {
                return new point(x, y);
            }

            public static point NewPolarPoint(double x, double y)
            {
                return new point(x * Math.Cos(x), y * Math.Tan(y));
            }
        }
    }

    class Caller
    {
        void main()
        {
            point p = point.Factory.NewCatresionPoint(45, 45);
        }
    }
}
