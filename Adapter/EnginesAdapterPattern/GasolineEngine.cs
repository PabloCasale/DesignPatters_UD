using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter.EnginesAdapterPattern
{
    public class GasolineEngine : Engine
    {
        public override void Accelerate()
        {
            Console.WriteLine("Accelerating Gasoline Engine");
        }

        public override void LoadFuel()
        {
            Console.WriteLine("Loading Fuel for gasoline engine");
        }

        public override void ShutDown()
        {
            Console.WriteLine("Shutting down gasoline Engine");
        }

        public override void Start()
        {
            Console.WriteLine("Starting gasoline engine");
        }
    }
}