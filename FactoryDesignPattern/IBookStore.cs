using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryDesignPattern
{
    //the FACTORY
    public interface IBookStore
    {
        //LD the concrete class of "BookStore" will decide which distributor implement 
        // based on the parm "location" received by the contructor.
        IDistributor GetDistributor();
    }
}
