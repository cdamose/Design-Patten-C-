using Builder.FacetedBuilder;
using Builder.FlunetBuilder.Model;
using Builder.NonFluentBuilder;
using System;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            //call non fluent builer
            HtmlBuilder builder = new HtmlBuilder("ul");
            builder.AddChild("li", "one");
            builder.AddChild("li", "two");
            builder.AddChild("li", "three");
            Console.WriteLine(builder.ToString());
            //call fluent buiilder pattern
            Employee emp= Employee.New.SetName("AMOSE").WorkingAs("Architect").Build();

            //faceted builder
            PersonBuilder v = new PersonBuilder();
            Person person = v
                .lives.LivesAt("tuty")
                .AreaCode("628008")
                .works.AsA("software enginier").
                                    At("lynk").
                                    Earning(0000);
        }
    }
}
