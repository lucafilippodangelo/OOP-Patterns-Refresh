using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryDesignPattern
{
    //concrete factory
    public class BookStoreA : IBookStore
    {
        private CustomerLocation location;

        public BookStoreA(CustomerLocation location)
        {
            this.location = location;
        }

        IDistributor IBookStore.GetDistributor()
        {
            //internal logic on which distributor to return
            //*** logic can be changed without changing the client code  ****
            switch (location)
            {
                case CustomerLocation.EastCoast:
                    return new EastCoastDistributor();
                case CustomerLocation.WestCoast:
                    return new WestCoastDistributor();
            }
            return null;
        }

        IAdvertiser IBookStore.GetAdvertiser()
        {
            //internal logic on which distributor to return
            //*** logic can be changed without changing the client code  ****
            switch (location)
            {
                case CustomerLocation.EastCoast:
                    return new RedAdvertiser();
                case CustomerLocation.WestCoast:
                    return new BlueAdvertiser();
            }
            return null;
        }
    }

}
