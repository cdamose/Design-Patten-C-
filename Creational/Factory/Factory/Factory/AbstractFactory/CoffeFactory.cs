using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;
namespace Factory.AbstractFactory
{
    internal class CoffeFactory : IHotDrinkFactory
    {
        public IHotDrink Prepare(int amount)
        {
            WriteLine(" Your coffe is preparing pls wait");
            return new Coffe();
        }
    }
}
