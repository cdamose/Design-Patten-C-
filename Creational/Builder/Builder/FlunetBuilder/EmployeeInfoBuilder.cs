using Builder.FlunetBuilder.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Builder.FlunetBuilder
{
    public class EmployeeInfoBuilder<SELF> : EmployeeBuilder
        where SELF : EmployeeInfoBuilder<SELF>
    {
        protected Employee employee=new Employee();
        public SELF SetName(string Name)
        {
            employee.Name = Name;
            return (SELF)this;
        }

    }
}
