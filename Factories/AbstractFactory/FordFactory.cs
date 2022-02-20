using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factories.AbstractFactory
{
    public class FordFactory : VehicleFactory
    {
        public override Car CreateCar(string name)
        {
            return new Ford() { Name = name };
        }

        public override Truck CreateTruck(string name)
        {
            return new Ranger() { Name = name };
        }
    }
}