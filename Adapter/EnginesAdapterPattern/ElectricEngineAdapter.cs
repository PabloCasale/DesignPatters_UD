using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter.EnginesAdapterPattern
{
    public class ElectricEngineAdapter : Engine
    {
        private readonly ElectricEngine electricEngine = new();

        public override void Accelerate()
        {
            electricEngine.Move();
        }

        public override void LoadFuel()
        {
            electricEngine.Charge();
        }

        public override void ShutDown()
        {
            electricEngine.Deactivate();
            electricEngine.Stop();
        }

        public override void Start()
        {
            electricEngine.Connect();
            electricEngine.Activate();
        }
    }
}