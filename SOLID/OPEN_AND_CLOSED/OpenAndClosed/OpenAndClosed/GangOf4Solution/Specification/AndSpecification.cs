using System;
using System.Collections.Generic;
using System.Text;

namespace OpenAndClosed.GangOf4Solution.Specification
{
   public class AndSpecification<T> :ISpecification<T>
    {
        ISpecification<T> _first, _second;
        public AndSpecification(ISpecification<T> first,ISpecification<T> second)
        {
            _first = first;
            _second = second;
        }

        public override bool IsSatisfied(T p)
        {
            return _first.IsSatisfied(p) && _second.IsSatisfied(p);
        }
    }
}
