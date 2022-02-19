using Builder.Employees;
using System;

namespace Builder
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Builder Pattern");

            //var builder = new HtmlBuilder("ul");
            //builder.AddChild("li", "hello");
            //builder.AddChild("li", "world");
            //Console.WriteLine(builder.ToString());

            var builder = new HtmlBuilder("ul");
            builder.AddChild("li", "hello").AddChild("li", "world");
            Console.WriteLine(builder.ToString());

            var eb = new EmployeeBuilderFacade();
            Employee employee = eb.Lives.At("Middle Earth")
                                    .City("Rohan")
                                    .WithPostCode("6658")
                            .Works.At("IBM")
                                   .AsA("Developer")
                                   .Earning(60000);

            Console.WriteLine(employee);
        }
    }
}