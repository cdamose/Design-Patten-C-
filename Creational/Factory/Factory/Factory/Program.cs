using Factory.AbstractFactory;
using System;
using System.Collections.Generic;
using static System.Console;
namespace Factory
{
    class Program
    {
      static  List<Tuple<string, IHotDrinkFactory>> factories = new List<Tuple<string, IHotDrinkFactory>>();
           
        static void Main(string[] args)
        {
            foreach (var t in typeof( HotDrinkMachine).Assembly.GetTypes())
            {
                if (typeof(IHotDrinkFactory).IsAssignableFrom(t) && !t.IsInterface)
                {
                    WriteLine(t.Name);
                    factories.Add(Tuple.Create(
                        t.Name.Replace("Factory",String.Empty),
                        (IHotDrinkFactory)Activator.CreateInstance(t)));
                }

            }
            int pos = 0;
            foreach (var item in factories)
            {
                WriteLine($"{pos}  : {item.Item1}");
                pos++;
            }
            factories[0].Item2.Prepare(100);
            factories[1].Item2.Prepare(50);


        }
    }
}
