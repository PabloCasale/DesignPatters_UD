using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factories.FactoryMethod
{
    public class MotherboardFactory
    {
        public static Motherboard GetMotherboard(ProcessorModels type)
        {
            switch (type)
            {
                case ProcessorModels.Ryzen3:
                    return new AMD();

                case ProcessorModels.Ryzen5:
                    return new AMD();

                case ProcessorModels.Ryzen9:
                    return new AMD();

                case ProcessorModels.Threadripper:
                    return new AMD();

                case ProcessorModels.I5:
                    return new Intel();

                case ProcessorModels.I7:
                    return new Intel();

                case ProcessorModels.I9:
                    return new Intel();

                default:
                    return null;
            }
        }
    }
}