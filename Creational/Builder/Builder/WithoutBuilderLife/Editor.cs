using System;
using System.Collections.Generic;
using System.Text;

namespace Builder.WithoutBuilderLife
{
    public class Editor
    {
        public void BuildStaticContent()
        {
            var hello = "hello S***A";
            var sb = new StringBuilder();
            sb.Append("<p>");
            sb.Append(hello);
            sb.Append("</p>");
            Console. WriteLine(sb);

        }

        public void BuildULTage()
        {
            var sb = new StringBuilder();
            sb.Append("<ul>");
            for (int i = 0; i < 2; i++)
            {
                sb.Append("<li>item "+i+"</li>");
            }
            sb.Append("</ul>");
            Console.WriteLine(sb);
        } 

    }
}
