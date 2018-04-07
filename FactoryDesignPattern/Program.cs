using System;

namespace FactoryDesignPattern
{
    public class Program
    {
        public enum CustomerLocation { EastCoast, MidWest, WestCoast }

        public static void Main(string[] args) {}

        //LDF002 client code does not need to be changed if the logic for choosing the distributor
        // in each BookStore will change
        public static void ShipBook(IBookStore s)
        {
            /*
             The key is your customer should not care which distributor you choose because they will get their books
             regardless. It is completely hidden from the customer's point of view and they should not be concerned 
             about it. You, the online bookstore, are the one that determines the distributor to use.
             */
            // the book store guy say that he need of a distributor for a specific location, but 
            // he doesn't know which real distributor will be implemented. 

            // FACTORY METHOD //the client gets the distributor without having to know which distributor is being used
            //LDF003 Notice that this client code don’t need to care which distributor is being created, 
            //and this is the key to the factory method pattern.
            IDistributor d = s.GetDistributor();

            // IN a second time the distributor implemented will ship the book.
            d.ShipBook();
        }
    }
}
