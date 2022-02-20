using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype.CarsPrototype
{
    public class ToyotaPrototype : CarPrototype
    {
        public override string GetDescription()
        {
            return $"Toyota - Model:{model} - Color: {color} ";
        }

        public override CarPrototype Clone()
        {
            return (ToyotaPrototype)this.MemberwiseClone();
        }
    }
}