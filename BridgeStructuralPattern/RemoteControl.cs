using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeStructuralPattern
{
    //LDBRG002
    //concrete abstraction
    public class RemoteControl : Switch
    {
        public RemoteControl(IAppliance i)
        {
            this.appliance = i;
        }

        public override void TurnOn()
        {
            appliance.Run();
        }
    }
}
