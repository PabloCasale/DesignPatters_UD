using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter.EnginesAdapterPattern
{
    public abstract class Engine
    {
        public abstract void Start();

        public abstract void ShutDown();

        public abstract void Accelerate();

        public abstract void LoadFuel();
    }
}