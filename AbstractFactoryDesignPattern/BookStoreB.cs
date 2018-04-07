using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryDesignPattern
{
    //concrete factory
    public class BookStoreB : IBookStore
    {
        private CustomerLocation location;

        public BookStoreB(CustomerLocation location)
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
                    return new BlueAdvertiser();
                case CustomerLocation.WestCoast:
                    return new RedAdvertiser();
            }
            return null;
        }
    }
}
