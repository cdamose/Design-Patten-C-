using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace Factory.AbstractFactory
{
    internal class TeaFactory : IHotDrinkFactory
    {
        public IHotDrink Prepare(int amount)
        {
            WriteLine($"preparing tea pls wait {amount}");
            return new Tea();
        }
    }
}
