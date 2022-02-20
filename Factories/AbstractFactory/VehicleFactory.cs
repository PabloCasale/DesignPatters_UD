using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factories.AbstractFactory
{
    public abstract class VehicleFactory
    {
        public abstract Car CreateCar(string name);

        public abstract Truck CreateTruck(string name);
    }
}