using System;
using System.Collections.Generic;
using System.Text;

namespace Builder.FacetedBuilder
{
    public class PersonJobBuilder : PersonBuilder
    {
        public PersonJobBuilder(Person person)
        {
            this.person = person;
        }
        public PersonJobBuilder At(string companyname)
        {
            this.person.compnayname = companyname;
            return this;
        }
        public PersonJobBuilder AsA(string position)
        {
            this.person.position = position;
            return this;
        }
        public PersonJobBuilder Earning(int salary)
        {
            this.person.annualincome = salary;
            return this;
        }

    }
}
