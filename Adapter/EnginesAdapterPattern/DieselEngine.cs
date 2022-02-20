using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter.EnginesAdapterPattern
{
    public class DieselEngine : Engine
    {
        public override void Accelerate()
        {
            Console.WriteLine("Accelerating Diesel Engine");
        }

        public override void LoadFuel()
        {
            Console.WriteLine("Loading Fuel for Diesel engine");
        }

        public override void ShutDown()
        {
            Console.WriteLine("Shutting down Diesel Engine");
        }

        public override void Start()
        {
            Console.WriteLine("Starting Diesel engine");
        }
    }
}