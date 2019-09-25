using System;
using System.Collections.Generic;
using System.Text;

namespace Builder.FacetedBuilder
{
    public class PersonAddressBuilder :PersonBuilder
    {
        public PersonAddressBuilder(Person person)
        {
            this.person = person;
        }

        public PersonAddressBuilder LivesAt(string streetname)
        {
            this.person.streetAddress = streetname;
            return this;
        }
        public PersonAddressBuilder AreaCode(string postcode)
        {
            this.person.postcode = postcode;
            return this;
        }

    }
}
