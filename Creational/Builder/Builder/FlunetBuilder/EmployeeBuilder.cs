using Builder.FlunetBuilder.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Builder.FlunetBuilder
{
   public abstract class EmployeeBuilder
    {
        Employee obj;
        public EmployeeBuilder()
        {
            obj = new Employee();
        }
        public Employee Build() => obj;
        
    }
}
