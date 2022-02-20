using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter.EnginesAdapterPattern
{
    public class ElectricEngine
    {
        private bool connected, active, moving;

        public void Connect()
        {
            if (connected)
            {
                Console.WriteLine("Error: The engine is already connected");
            }
            else
            {
                connected = true;
                Console.WriteLine("Engine connected");
            }
        }

        public void Activate()
        {
            if (!connected)
            {
                Console.WriteLine("ERROR: Engine is not connected");
            }
            else
            {
                active = true;
                Console.WriteLine("Engine Activated");
            }
        }

        public void Deactivate()
        {
            if (active)
            {
                active = false;
                Console.WriteLine("Engine deactivated");
            }
            else
            {
                Console.WriteLine("ERROR: Engine already deactivated");
            }
        }

        public void Move()
        {
            if (connected && active)
            {
                moving = true;
                Console.WriteLine("Accelerating electric Engine");
            }
            else
            {
                Console.WriteLine("ERROR: Electric Engine should be connected and active");
            }
        }

        public void Stop()
        {
            if (moving)
            {
                moving = false;
                Console.WriteLine("Stopping electric Engine");
            }
            else
            {
                Console.WriteLine("ERROR: Engine already moving, cannot be shut down untill it stoped");
            }
        }

        public void Disconnect()
        {
            if (connected)
            {
                moving = false;
                Console.WriteLine("Engine Disconnected");
            }
            else
            {
                Console.WriteLine("ERROR: Engine already disconnected");
            }
        }

        public void Charge()
        {
            if (!active)
            {
                Console.WriteLine("Charging electric Engine...");
            }
            else
            {
                Console.WriteLine("ERROR: Engine cannot be charged while is active");
            }
        }
    }
}