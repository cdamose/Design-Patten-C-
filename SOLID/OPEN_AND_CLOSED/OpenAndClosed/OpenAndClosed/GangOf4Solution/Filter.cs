using System;
using System.Collections.Generic;
using System.Text;

namespace OpenAndClosed.GangOf4Solution
{
    public class Filter<T> : IFilter<T>
    {
        public IEnumerable<T> ApplyFilter(IEnumerable<T> items, Specification.ISpecification<T> specification)
        {
            foreach (var item in items)
            {
                if (specification.IsSatisfied(item))
                yield return  item;
            }
        }
    }
}
