using System;
using System.Collections.Generic;
using System.Text;

namespace Factory.AbstractFactory
{
    class Caller
    {
        void main()
        {
            var HotDrinkMachine = new HotDrinkMachine();
            IHotDrink mydrink= HotDrinkMachine.MakeDrink(AvailableDrink.COFFEE, 100);
            mydrink.Consume();
        }
    }
}
