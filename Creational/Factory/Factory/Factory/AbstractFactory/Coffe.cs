using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;
namespace Factory.AbstractFactory
{
    internal class Coffe : IHotDrink
    {
        public void Consume()
        {
            WriteLine("I Like This Coffe ...!");
        }
    }
}
