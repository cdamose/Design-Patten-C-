using System;
using System.Collections.Generic;
using System.Text;

namespace Factory.AbstractFactory.OCP
{
   public interface IHotDrinkFactory
    {
        IHotDrink Prepare(int amount);
    }
}
