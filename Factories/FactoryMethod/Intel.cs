using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factories.FactoryMethod
{
    public class Intel : Motherboard
    {
        public override string Architecture()
        {
            return "INTEL";
        }
    }
}