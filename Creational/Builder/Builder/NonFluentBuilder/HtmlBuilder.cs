using Builder.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Builder.NonFluentBuilder
{
    public class HtmlBuilder
    {
        private readonly string _rootName;
        protected HtmlElemet root = new HtmlElemet();
        public HtmlBuilder(string rootname)
        {
            this.root.Name = rootname;

        }

       public bool AddChild(string childName,string childText)
        {
            try
            {
                HtmlElemet child = new HtmlElemet { Name = childName, Text = childText };
                this.root.Elements.Add(child);
                return true;
            }
            catch(Exception e)
            {
                return false;
            }
            
        }
        public override string ToString() => root.ToString();
        
    }
}
