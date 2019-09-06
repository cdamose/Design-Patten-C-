using System;
using System.Collections.Generic;
using System.Text;

namespace Builder.FlunetBuilder
{
    public class EmployeeJobBuilder<SELF> : EmployeeInfoBuilder<EmployeeJobBuilder<SELF>>
        where SELF : EmployeeJobBuilder<SELF>
    {
        
        public SELF WorkingAs(string position)
        {
            employee.Position = position;
            return (SELF)this;
        }

    }
}
