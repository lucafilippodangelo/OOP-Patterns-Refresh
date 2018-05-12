using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverBehavioralPattern
{
    public interface IObserver<T>
    {
        void Update(T subjectState);
        //T GetState();
    }
}
