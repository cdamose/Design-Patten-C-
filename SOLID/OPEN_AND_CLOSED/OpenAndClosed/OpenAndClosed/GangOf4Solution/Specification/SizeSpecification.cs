using OpenAndClosed.Model;
using OpenAndClosed.Type;
using System;
using System.Collections.Generic;
using System.Text;

namespace OpenAndClosed.GangOf4Solution.Specification
{
    public class SizeSpecification : ISpecification<Product>
    {
        Size _size;
        public SizeSpecification(Size size)
        {
            _size = size;
        }
        public override bool IsSatisfied(Product p)
        {
            return p.Sizes == _size;
        }
    }
}
