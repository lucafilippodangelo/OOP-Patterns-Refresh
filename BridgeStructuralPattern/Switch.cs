using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeStructuralPattern
{
    //the abstraction
    public abstract class Switch
    {
        protected IAppliance appliance;
        public abstract void TurnOn();
    }
}
