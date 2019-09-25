using System;
using System.Collections.Generic;
using System.Text;

namespace Factory.AbstractFactory.OCP
{
    class Caller
    {
        void main()
        {
            var HotDrinkMachine = new HotDrinkMachine();
           IHotDrink mydrink= HotDrinkMachine.MakeDrink(0, 100);
            mydrink.Consume();
        }
    }
}
