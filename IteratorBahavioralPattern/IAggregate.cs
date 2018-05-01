using System;
using System.Collections.Generic;
using System.Text;

namespace IteratorBahavioralPattern
{
    //LDITE004
    public interface IAggregate<T>
    {
        IIterator<T> CreateIterator();
        List<T> GetAll();
        void AddItem(T item);
    }
}
