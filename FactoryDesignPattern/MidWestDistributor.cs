using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryDesignPattern
{
    //concrete product
    public class MidWestDistributor : IDistributor
    {
        void IDistributor.ShipBook()
        {
            Console.WriteLine("Book shipped by Mid West Distributor");
        }
    }
}
