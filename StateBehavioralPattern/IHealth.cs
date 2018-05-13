using System;
using System.Collections.Generic;
using System.Text;

namespace StateBehavioralPattern
{
    //LDSTA001
    // this interface represent the possible "statuses"
    // in this pattern we use a behavior to switch to another behavior
    public interface IHealth
    {
        void DoBattle(Warrior w);
    }
}
