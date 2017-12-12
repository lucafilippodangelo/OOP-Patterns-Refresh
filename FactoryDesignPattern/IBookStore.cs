using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryDesignPattern
{
    //the FACTORY
    public interface IBookStore
    {
        IDistributor GetDistributor();
    }
}
