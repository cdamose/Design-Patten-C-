using OpenAndClosed.Model;
using OpenAndClosed.Type;
using System;
using System.Collections.Generic;
using System.Text;

namespace OpenAndClosed.MySolution
{
   public class Filter
    {
        public static IEnumerable<Product> FilterBySize(IEnumerable<Product> list,Size size)
        {
            foreach (var item in list)
            {
                if (item.Sizes==size)
                yield return item;
            }
        }
        public static IEnumerable<Product> FilterByColor(IEnumerable<Product> list, Color color)
        {
            foreach (var item in list)
            {
                if (item.Color == color)
                    yield return item;
            }
        }

        public static IEnumerable<Product> FilterBySizeAndColor(IEnumerable<Product> list, Color color,Size size)
        {
            foreach (var item in list)
            {
                if (item.Color == color &&item.Sizes==size)
                    yield return item;
            }
        }
    }
}
