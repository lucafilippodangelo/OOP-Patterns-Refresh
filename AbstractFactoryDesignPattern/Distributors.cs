using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryDesignPattern
{
    //LDAF006
    //concrete product
    public class EastCoastDistributor : IDistributor
    {
        void IDistributor.ShipBook()
        {
            Console.WriteLine("Book shipped by East Coast Distributor");
        }
    }

    //concrete product
    public class WestCoastDistributor : IDistributor
    {
        void IDistributor.ShipBook()
        {
            Console.WriteLine("Book shipped by West Coast Distributor");
        }
    }
}
