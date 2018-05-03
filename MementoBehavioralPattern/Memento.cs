using System;
using System.Collections.Generic;
using System.Text;

namespace MementoBehavioralPattern
{
    //LDMEM002
    //object that stores the historical state
    public class Memento<T>
    {
        private T state;

        public T GetState()
        {
            return state;
        }

        public void SetState(T state)
        {
            this.state = state;
        }
    }
}
