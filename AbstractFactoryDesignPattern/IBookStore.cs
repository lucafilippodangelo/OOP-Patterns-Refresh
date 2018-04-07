using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryDesignPattern
{
    //the factory
    public interface IBookStore
    {
        IDistributor GetDistributor();
        IAdvertiser GetAdvertiser();
    }
}
