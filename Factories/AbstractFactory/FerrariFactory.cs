using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factories.AbstractFactory
{
    public class FerrariFactory : VehicleFactory
    {
        public override Car CreateCar(string name)
        {
            return new Ferrari { Name = name };
        }

        public override Truck CreateTruck(string name)
        {
            throw new NotImplementedException();
        }
    }
}