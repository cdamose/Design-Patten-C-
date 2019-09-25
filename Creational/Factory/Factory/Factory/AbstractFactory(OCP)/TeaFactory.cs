using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace Factory.AbstractFactory.OCP
{
    internal class TeaFactory : IHotDrinkFactory
    {
        public IHotDrink Prepare(int amount)
        {
            WriteLine("preparing coffe pls wait");
            return new Tea();
        }
    }
}
