using OpenAndClosed.GangOf4Solution;
using OpenAndClosed.GangOf4Solution.Specification;
using OpenAndClosed.Model;
using OpenAndClosed.Type;
using System;
using System.Collections.Generic;

namespace OpenAndClosed
{
    class Program
    {
        static Product[] InitializeArray()
        {
            List<Product> list = new List<Product>();
            list.Add(new Product { Color=Color.Green, Name="Green Apple",Sizes=Size.Medium});
            list.Add(new Product { Color = Color.Red, Name = "Truck", Sizes = Size.Large });
            list.Add(new Product { Color = Color.Yellow, Name = "Eraser", Sizes = Size.Small });
            return list.ToArray();
        }
        static void Main(string[] args)
        {
            var listData = InitializeArray();
            Filter<Product> filter=new Filter<Product>();
            var filter_data=filter.ApplyFilter(listData, new SizeSpecification(Size.Medium));
            
        }
    }
}
