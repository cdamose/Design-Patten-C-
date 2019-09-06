using System;
using System.Collections.Generic;
using System.Text;

namespace Builder.Model
{
    public class HtmlElemet
    {
        public List<HtmlElemet> Elements = new List<HtmlElemet>();
        const int intent_size = 5;
        public string Name, Text;
       public HtmlElemet()
        {

        }
        public HtmlElemet(string name ,string text)
        {
          Name = name;
            Text = text;
        }
        public String ToFormatString(int intent) {
            var sb = new StringBuilder();
            var i = new string(' ', intent  * intent_size);
            sb.Append(new String(' ', intent * intent_size));
            sb.Append($"<{Name}>");
            sb.Append(new String(' ', intent+1 * intent_size));
            sb.Append(Text);
            sb.Append("/n");
            foreach (var item in Elements)
                sb.Append(item.ToFormatString(intent + 1));
            sb.Append($"{i}</{Name}>");
            return sb.ToString();
        }
        public override String ToString()
        {
            return ToFormatString(0);
        }
    }
}
