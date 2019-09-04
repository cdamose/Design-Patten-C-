using System;
using System.Collections.Generic;
using System.Text;

namespace OpenAndClosed.GangOf4Solution.Specification
{
    public abstract class ISpecification<T>
    {
        public abstract bool IsSatisfied(T p);
    }
}
