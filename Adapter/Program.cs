using Adapter.EnginesAdapterPattern;
using System;

namespace Adapter
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Adapter Pattern");

            var gasEngine = new GasolineEngine();
            gasEngine.Start();
            gasEngine.Accelerate();
            gasEngine.ShutDown();
            gasEngine.LoadFuel();

            var dieselEngine = new DieselEngine();
            dieselEngine.Start();
            dieselEngine.Accelerate();
            dieselEngine.ShutDown();
            dieselEngine.LoadFuel();

            var electricEngine = new ElectricEngineAdapter();
            electricEngine.Start();
            electricEngine.Accelerate();
            electricEngine.ShutDown();
            electricEngine.LoadFuel();
        }
    }
}