using FactoryDesignPattern;
using AbstractFactoryDesignPattern;
using MediatorDesignPattern;
using SingletonCreationalPattern;
using System;
using static FactoryDesignPattern.Program;

namespace PatternsRefresh
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //RunMediatorDesignPattern(); //LD_MEDIATOR_000
            //RunSingletonDesignPattern(); //LD_SINGLETON_000
            //RunFactoryDesignPattern(); //LD_FACTORY_000
            RunAbstractFactoryDesignPattern(); //LD_ABSTRACT_FACTORY_000
        }

        //LD_MEDIATOR_000
        public static void RunMediatorDesignPattern() {
            Mediator lucaMediator = new Mediator(); 

            ColleagueOne c1 = new ColleagueOne(lucaMediator); //LD creation of concrete instance of "Coleague", need to pass "Mediator" instance
            lucaMediator.c1 = c1; //LD set "c1" in concrete "Mediator" instance

            ColleagueTwo c2 = new ColleagueTwo(lucaMediator);
            lucaMediator.c2 = c2;

            ColleagueThree c3 = new ColleagueThree(lucaMediator);
            lucaMediator.c3 = c3;

            //LD test of "Mediator" logic
            c1.Send("msg001");
            c2.Send("msg002");

            Console.ReadLine();
        }

        //LD_SINGLETON_000
        public static void RunSingletonCreationalPattern() {
            Singleton s1 = Singleton.Instance;
            Singleton s2 = Singleton.Instance;

            // Test for same instance

            if (s1 == s2)
            {
                Console.WriteLine("Objects are the same instance");
            }

            Console.ReadKey();
        }

        //LD_FACTORY_000
        public static void RunFactoryDesignPattern()
        {
            Console.WriteLine("East Coast Customer:");
            //LDF001 we can abstract out the BookStore as an interface and have more types of bookstores
            FactoryDesignPattern.IBookStore bookstore = new FactoryDesignPattern.BookStoreA(FactoryDesignPattern.Program.CustomerLocation.EastCoast);
            ShipBook(bookstore);

            Console.WriteLine("Mid West Customer:");
            bookstore = new FactoryDesignPattern.BookStoreA(FactoryDesignPattern.Program.CustomerLocation.MidWest);
            ShipBook(bookstore);

            Console.WriteLine("West Coast Customer:");
            bookstore = new FactoryDesignPattern.BookStoreA(FactoryDesignPattern.Program.CustomerLocation.WestCoast);
            ShipBook(bookstore);

            Console.ReadKey();
        }

        //LD_ABSTRACT_FACTORY_000
        public static void RunAbstractFactoryDesignPattern()
        {
            //LDAF001
            AbstractFactoryDesignPattern.IBookStore storeA = new AbstractFactoryDesignPattern.BookStoreA(AbstractFactoryDesignPattern.CustomerLocation.EastCoast);
            Console.WriteLine("Book Store A with a customer from East Coast:");

            //LDAF002
            AbstractFactoryDesignPattern.Program.ShipBook(storeA);
            AbstractFactoryDesignPattern.Program.Advertise(storeA);

            AbstractFactoryDesignPattern.IBookStore storeB = new BookStoreB(AbstractFactoryDesignPattern.CustomerLocation.WestCoast);
            Console.WriteLine("Book Store B with a customer from West Coast:");
            AbstractFactoryDesignPattern.Program.ShipBook(storeB);
            AbstractFactoryDesignPattern.Program.Advertise(storeB);

            Console.ReadKey();
        }

        }//LD end Program
}//LD close namespace
