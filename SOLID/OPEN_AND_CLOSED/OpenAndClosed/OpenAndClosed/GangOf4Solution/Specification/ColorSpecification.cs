using OpenAndClosed.Model;
using OpenAndClosed.Type;
using System;
using System.Collections.Generic;
using System.Text;

namespace OpenAndClosed.GangOf4Solution.Specification
{
    public class ColorSpecification : ISpecification<Product>
    {
        Color _color;
        public ColorSpecification(Color color)
        {
            _color = color;
        }
        public override bool IsSatisfied(Product p)
        {
            return p.Color == _color;
        }
    }
}
