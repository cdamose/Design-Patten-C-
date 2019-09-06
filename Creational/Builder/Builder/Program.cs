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

        }
    }
}
