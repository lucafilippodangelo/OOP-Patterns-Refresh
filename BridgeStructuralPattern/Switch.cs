using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeStructuralPattern
{
    //LDBRG001
    //the abstraction
    public abstract class Switch
    {
        protected IAppliance appliance;
        public abstract void TurnOn();
    }
}
