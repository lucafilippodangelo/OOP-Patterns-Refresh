using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverBehavioralPattern
{
    //LDOBS002 
    public class ConcreteSubject<T> : ISubject<T>
    {
        private List<IObserver<T>> Observers = new List<IObserver<T>>();
        private T SubjectState;

        List<IObserver<T>> ISubject<T>.Observers
        {
            get { return Observers; }
        }

        void ISubject<T>.Attach(IObserver<T> i)
        {
            Observers.Add(i);
        }

        IObserver<T> ISubject<T>.Detach(IObserver<T> i)
        {
            Observers.Remove(i);
            return i;
        }

        void ISubject<T>.Notify()
        {
            foreach (IObserver<T> o in Observers)
                o.Update(SubjectState);   //update the observer
        }

        T ISubject<T>.GetState()
        {
            return SubjectState;
        }

        void ISubject<T>.SetState(T state)
        {
            SubjectState = state;
            ((ISubject<T>)this).Notify();  //notify the observers of the change
        }
    }

}
