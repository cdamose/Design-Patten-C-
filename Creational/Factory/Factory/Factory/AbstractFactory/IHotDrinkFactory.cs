using System;
using System.Collections.Generic;
using System.Text;

namespace Factory.AbstractFactory
{
   public interface IHotDrinkFactory
    {
        IHotDrink Prepare(int amount);
    }
}
