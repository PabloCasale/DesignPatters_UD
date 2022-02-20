using Prototype.CarsPrototype;
using System;

namespace Prototype
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Prototype");

            CarPrototype audi = new AudiPrototype();
            CarPrototype bmw = new BmwPrototype();
            CarPrototype toyota = new ToyotaPrototype();

            var audiTT = audi.Clone();
            audiTT.Model = "TT";
            audiTT.Color = "Black";
            Console.WriteLine(audiTT.GetDescription());

            var bmwX5 = bmw.Clone();
            bmwX5.Model = "X5";
            bmwX5.Color = "Silver";
            Console.WriteLine(bmwX5.GetDescription());

            var supra = toyota.Clone();
            supra.Model = "Supra";
            supra.Color = "Red";
            Console.WriteLine(supra.GetDescription());

            var bmwSerie2 = bmwX5.Clone();
            bmwSerie2.Model = "Serie 2";
            Console.WriteLine(bmwSerie2.GetDescription());

            //Prototype avoids the following "Same reference copy"
            var a = bmwSerie2;
            a.Model = "A";
            Console.WriteLine(a.GetDescription());
        }
    }
}