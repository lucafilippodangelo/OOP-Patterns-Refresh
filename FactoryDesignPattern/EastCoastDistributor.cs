using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryDesignPattern
{
    //concrete product
    public class EastCoastDistributor : IDistributor
    {
        void IDistributor.ShipBook()
        {
            Console.WriteLine("Book shipped by East Coast Distributor");
        }
    }
}
