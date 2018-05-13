using System;
using System.Collections.Generic;
using System.Text;

//LDSTA002
namespace StateBehavioralPattern
{
    public class SuperStrong : IHealth
    {
        void IHealth.DoBattle(Warrior w)
        {
            //warrior can transition to another state based on the outcome
            //of the action, in this case the "battle" action coming from a specific "state" 
            w.SetHealth(new Normal());
        }
    }

    public class Strong : IHealth
    {
        void IHealth.DoBattle(Warrior w)
        {
            //warrior can transition to another state based on the outcome
            //of the action, in this case the "battle" action coming from a specific "state" 
            w.SetHealth(new SuperStrong());
        }
    }

    public class Normal : IHealth
    {
        void IHealth.DoBattle(Warrior w)
        {
            //warrior can transition to another state based on the outcome
            //of the action, in this case the "battle" action coming from a specific "state" 
            w.SetHealth(new Weak());
        }
    }

    public class Weak : IHealth
    {
        void IHealth.DoBattle(Warrior w)
        {
            //warrior can transition to another state based on the outcome
            //of the action, in this case the "battle" action coming from a specific "state" 
            w.SetHealth(new Strong());
        }
    }
}
