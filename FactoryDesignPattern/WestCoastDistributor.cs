using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryDesignPattern
{
    //conceret product
    public class WestCoastDistributor : IDistributor
    {
        void IDistributor.ShipBook()
        {
            Console.WriteLine("Book shipped by West Coast Distributor");
        }
    }
}
