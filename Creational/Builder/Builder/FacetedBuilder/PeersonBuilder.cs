using System;
using System.Collections.Generic;
using System.Text;

namespace Builder.FacetedBuilder
{
   public class PersonBuilder
    {
        protected Person person = new Person();
        public PersonJobBuilder works => new PersonJobBuilder(person);

        public PersonAddressBuilder lives => new PersonAddressBuilder(person);
        public static implicit operator Person(PersonBuilder builder)
        {
            return builder.person;
        }

    }
}
