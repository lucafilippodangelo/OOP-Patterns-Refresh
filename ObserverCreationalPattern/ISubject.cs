using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverBehavioralPattern
{
    //LDOBS001
    public interface ISubject<T>
    {
        //LD Attributes
        List<IObserver<T>> Observers { get; }

        //LD methods
        void Attach(IObserver<T> i);
        IObserver<T> Detach(IObserver<T> i);
        void Notify();
        T GetState();
        void SetState(T state);
    }

}
