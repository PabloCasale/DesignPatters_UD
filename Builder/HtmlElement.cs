using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class HtmlElement
    {
        public string Name, Text;
        public List<HtmlElement> Elements = new List<HtmlElement>();
        private const int indentSize = 2;

        public HtmlElement(string name, string text)
        {
            if (name is null)
            {
                throw new ArgumentNullException(nameof(name));
            }

            if (text is null)
            {
                throw new ArgumentNullException(nameof(text));
            }
            Name = name;
            Text = text;
        }

        public HtmlElement()
        {
        }

        private string ToStringImplementation(int indent)
        {
            var sb = new StringBuilder();
            var ind = new string(' ', indentSize * indent);
            sb.AppendLine($"{ind}<{Name}>");

            if (!string.IsNullOrWhiteSpace(Text))
            {
                sb.Append(new string(' ', indentSize * (indent + 1)));
                sb.AppendLine(Text);
            }

            foreach (var item in Elements)
            {
                sb.Append(item.ToStringImplementation(indent + 1));
            }
            sb.AppendLine($"{ind}</{Name}>");
            return sb.ToString();
        }

        public override string ToString()
        {
            return ToStringImplementation(0);
        }
    }
}