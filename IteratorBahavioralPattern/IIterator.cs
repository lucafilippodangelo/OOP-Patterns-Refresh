using System;
using System.Collections.Generic;
using System.Text;

namespace IteratorBahavioralPattern
{
    //LDITE002
    public interface IIterator<T>
    {
        T First();
        T Next();
        T CurrentItem();
        bool IsDone();
        void AddItem(T item);
    }
}
