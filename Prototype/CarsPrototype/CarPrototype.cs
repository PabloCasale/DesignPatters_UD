using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype.CarsPrototype
{
    public abstract class CarPrototype
    {
        protected string color;

        public string Color
        {
            set { color = value; }
        }

        protected string model;

        public string Model
        {
            set { model = value; }
        }

        public abstract string GetDescription();

        public abstract CarPrototype Clone();
    }
}