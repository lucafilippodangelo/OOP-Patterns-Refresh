using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverBehavioralPattern
{
    //LDOBS004
    public class ConcreteObserver<T> : IObserver<T>
    {
        private T observerState;
        private string name;

        public ConcreteObserver(string name)
        {
            this.name = name;
        }

        void IObserver<T>.Update(T subjectState)
        {
            observerState = subjectState;
            Console.WriteLine(this.name + " is now " + this.observerState);
        }
    }
}
