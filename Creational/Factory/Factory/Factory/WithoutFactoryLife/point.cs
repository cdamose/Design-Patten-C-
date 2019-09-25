using Factory.WithoutFactoryLife.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace Factory.WithoutFactoryLife
{
   public class point
    {
        private int _x,_y;
        public point(int x,int y)
        {
            _x = x;
            _y = y;
        }
        public point(int a,int b, CoordinateSystem system= CoordinateSystem.Cartesian)
        {
            switch (system)
            {
                case CoordinateSystem.Cartesian:
                    _x = a;
                    _y = b;

                    break;
                case CoordinateSystem.polar:
                    _x =Convert.ToInt32( a* Math.Cos(a));
                    _y = Convert.ToInt32(a * Math.Cos(b));
                    break;
            }
        }
    }
}
