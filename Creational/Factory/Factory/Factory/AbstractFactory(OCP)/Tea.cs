using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace Factory.AbstractFactory.OCP
{
    internal class Tea : IHotDrink
    {
        public void Consume()
        {
            WriteLine("I lIke this Tea....! ");
        }
    }
}
