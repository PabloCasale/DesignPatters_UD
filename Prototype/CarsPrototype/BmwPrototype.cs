using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype.CarsPrototype
{
    public class BmwPrototype : CarPrototype
    {
        public override string GetDescription()
        {
            return $"BMW - Model:{model} - Color: {color} ";
        }

        public override CarPrototype Clone()
        {
            return (BmwPrototype)this.MemberwiseClone();
        }
    }
}