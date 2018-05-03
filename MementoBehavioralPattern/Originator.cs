using System;
using System.Collections.Generic;
using System.Text;

namespace MementoBehavioralPattern
{
    //the object that we want to save and restore, such as a check point in an application
    public class Originator<T>
    {
        //LDMEM001A
        private T state;

        //LDMEM001B
        //for saving the state
        public Memento<T> CreateMemento()
        {
            Memento<T> m = new Memento<T>();
            m.SetState(state);
            return m;
        }

        //LDMEM001C
        //for restoring the state in the Originator object
        public void SetMemento(Memento<T> m)
        {
            state = m.GetState();
        }

        //change the state of the Originator
        public void SetState(T state)
        {
            this.state = state;
        }

        //show the state of the Originator
        public void ShowState()
        {
            Console.WriteLine(state.ToString());
        }
    }

}
