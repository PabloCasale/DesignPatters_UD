using System;

namespace Strategy
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Strategy Pattern");

            var tp = new TextProcessor();

            tp.SetOutputFormat(OutputFormat.Markdown);
            tp.AppendList(new[] { "item A", "item B", "item C" });
            Console.WriteLine(tp);

            tp.Clear();

            tp.SetOutputFormat(OutputFormat.Html);
            tp.AppendList(new[] { "item A", "item B", "item C" });
            Console.WriteLine(tp);
        }
    }
}