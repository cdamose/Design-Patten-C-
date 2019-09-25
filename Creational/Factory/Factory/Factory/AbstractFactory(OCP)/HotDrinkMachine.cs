using System;
using System.Collections.Generic;
using System.Text;

namespace Factory.AbstractFactory.OCP
{

    //if we add hot choclate in this drink list 
    // we need to update this ennum
    // it's voilate Open /closed principle so we using below
    //public enum AvailableDrink
    //{
    //    COFFEE, TEA
    //}

    //public class HotDrinkMachine
    //{
    //    private Dictionary<AvailableDrink, IHotDrinkFactory> drinks = new Dictionary<AvailableDrink, IHotDrinkFactory>();
    //    public HotDrinkMachine()
    //    {
    //        foreach (AvailableDrink item in Enum.GetValues(typeof(AvailableDrink)))
    //        {
    //            var factory = (IHotDrinkFactory)
    //                Activator.CreateInstance(
    //                    Type.GetType(Enum.GetName(typeof(AvailableDrink), item)
    //                    ));

    //            drinks.Add(item, factory);
    //        }

    //    }
    //    public IHotDrink MakeDrink(AvailableDrink drink, int amount)
    //    {
    //        return drinks[drink].Prepare(100);
    //    }


    //}
    public class HotDrinkMachine
    {
        List<Tuple<string, IHotDrinkFactory>> factories = new List<Tuple<string, IHotDrinkFactory>>();
        public HotDrinkMachine()
        {
            foreach (var t in typeof(HotDrinkMachine).Assembly.GetTypes())
            {
                if(!t.IsInterface && typeof(IHotDrinkFactory).IsAssignableFrom(t))
                {
                    factories.Add(
                        Tuple.Create(t.Name.Replace("Factory", String.Empty),
                        (IHotDrinkFactory)Activator.CreateInstance(t)));
                }
            }
            
        }

        public IHotDrink MakeDrink(int pos,int amount)
        {
            return factories[pos].Item2.Prepare(amount);
        }
    }

}
