using OpenAndClosed.GangOf4Solution.Specification;
using System;
using System.Collections.Generic;
using System.Text;

namespace OpenAndClosed.GangOf4Solution
{
    public interface IFilter<T>
    {
        IEnumerable<T> ApplyFilter(IEnumerable<T> items,ISpecification<T> specification);
    }
}
