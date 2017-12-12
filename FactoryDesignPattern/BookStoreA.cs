using static FactoryDesignPattern.Program;

namespace FactoryDesignPattern
{
    //CONCRETE FACTORY
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
                case CustomerLocation.MidWest:
                    return new MidWestDistributor();
                case CustomerLocation.WestCoast:
                    return new WestCoastDistributor();
            }
            return null;
        }
    }
}
