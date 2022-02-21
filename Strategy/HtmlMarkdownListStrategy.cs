using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public class HtmlMarkdownListStrategy : IListStrategy
    {
        public void Start(StringBuilder sb)
        {
        }

        public void End(StringBuilder sb)
        {
        }

        public void AddListItem(StringBuilder sb, string item)
        {
            sb.AppendLine($" * {item}");
        }
    }
}