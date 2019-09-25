using System;
using System.Collections.Generic;
using System.Text;

namespace Factory.AbstractFactory
{
    public enum AvailableDrink
    {
         COFFEE,TEA
    }
    
   public class HotDrinkMachine
    {
        private Dictionary<AvailableDrink, IHotDrinkFactory> drinks = new Dictionary<AvailableDrink, IHotDrinkFactory>();
        public HotDrinkMachine()
        {
            foreach (AvailableDrink item in Enum.GetValues(typeof(AvailableDrink)))
            {
                var factory = (IHotDrinkFactory)
                    Activator.CreateInstance(
                        Type.GetType( Enum.GetName(typeof(AvailableDrink), item)
                        ));

                drinks.Add(item, factory);
            }

        }
        public IHotDrink MakeDrink(AvailableDrink drink,int amount)
        {
            return drinks[drink].Prepare(100);
        }


    }
}
