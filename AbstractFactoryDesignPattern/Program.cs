using System;

namespace AbstractFactoryDesignPattern
{
    public enum CustomerLocation { EastCoast, MidWest, WestCoast }

    public class Program
    {
        public static void Main(string[] args) { }

        //**** client code that does not need to be changed  ***
        public static void ShipBook(IBookStore s)
            {
                //LDAF003
                IDistributor d = s.GetDistributor();
                d.ShipBook();
            }

        //**** client code that does not need to be changed  ***
        /*
         * //LDAF007 - THE CORE
         Notice that regardless if you pass in BookStoreA or BookStoreB into the method above, this client code does 
         not need to be changed since it will get the correct advertiser automatically using the internal logics 
         within the factories. It is the factories (BookStoreA and BookStoreB) that determines which advertiser to produce.
         The same goes for choosing which book distributor to produce.

        The benefit of the Abstract Factory pattern is that it allows you to create a groups of products
        (the distributors and the advertisers) without having to know the actual class of the product being produced. 
        The result is that you can have client code that does not need to be changed when  the internal logic of 
        the factories on which product to produce changed.
         */
        public static void Advertise(IBookStore s)
            {
                //LDAF004
                IAdvertiser a = s.GetAdvertiser();
                a.Advertise();
            }
    }
}
