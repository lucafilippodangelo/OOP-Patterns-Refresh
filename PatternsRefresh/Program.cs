using FactoryDesignPattern;
using AbstractFactoryDesignPattern;
using MediatorDesignPattern;
using SingletonCreationalPattern;
using System;
using static FactoryDesignPattern.Program;
using BuilderCreationalPattern;
using PrototypeCreationalPattern;
using AdapterStructuralPattern;
using System.Collections.Generic;
using BridgeStructuralPattern;

namespace PatternsRefresh
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //RunMediatorDesignPattern(); //LD_MEDIATOR_000
            //RunSingletonDesignPattern(); //LD_SINGLETON_000
            //RunFactoryDesignPattern(); //LD_FACTORY_000
            //RunAbstractFactoryDesignPattern(); //LD_ABSTRACT_FACTORY_000
            //RunBuilderCreationalPattern(); //LD_BUILDER_000
            //RunPrototypeCreationalPattern(); //LD_PROTOTYPE_000
            //RunAdapterStructuralPattern(); //LD_ADAPTER_000
            RunBridgeStructuralPattern(); //LD_BRIDGE_000

            Console.ReadLine();
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

            //LD identical situation for advertisement
            AbstractFactoryDesignPattern.IBookStore storeB = new BookStoreB(AbstractFactoryDesignPattern.CustomerLocation.WestCoast);
            Console.WriteLine("Book Store B with a customer from West Coast:");
            AbstractFactoryDesignPattern.Program.ShipBook(storeB);
            AbstractFactoryDesignPattern.Program.Advertise(storeB);
        }

        //LD_BUILDER_000
        public static void RunBuilderCreationalPattern()
        {
            Director d = new Director();

            Console.WriteLine("Build a jet airplane");
            //LDB004
            Airplane a = d.BuildAirplane(new JetManufacturer());
            a.Show();

            Console.WriteLine("Build a propeller airplane");
            Airplane b = d.BuildAirplane(new PropellerManufacturer());
            b.Show();
        }

        //LD_PROTOTYPE_000
        public static void RunPrototypeCreationalPattern()
        {
            Configuration c = new Configuration();
            DateTime startTime = DateTime.Now;
            c.GetFileInformation();  //takes long time to create the first time
            DateTime endTime = DateTime.Now;
            Console.WriteLine("First Configuration object took " + endTime.Subtract(startTime).TotalSeconds + " seconds");

            UserProfile p = new UserProfile();
            startTime = DateTime.Now;
            p.GetDatabaseInformation();  //takes long time to create the first time
            endTime = DateTime.Now;
            Console.WriteLine("First UserProfile object took " + endTime.Subtract(startTime).TotalSeconds + " seconds");

            //add prototypes to the manager
            PrototypeManager manager = new PrototypeManager();
            manager.AddPrototype(c, 0);
            manager.AddPrototype(p, 1);

            startTime = DateTime.Now;
            (manager.GetPrototype(0).Clone() as Configuration).ShowInformation();  //new prototype copy
            endTime = DateTime.Now;
            Console.WriteLine("Second Configuration object took " + endTime.Subtract(startTime).TotalSeconds + " seconds");

            startTime = DateTime.Now;
            (manager.GetPrototype(1).Clone() as UserProfile).ShowInformation();  //new prototype copy
            endTime = DateTime.Now;
            Console.WriteLine("Second UserProfile object took " + endTime.Subtract(startTime).TotalSeconds + " seconds");
        }

        //LD_ADAPTER_000
        public static void RunAdapterStructuralPattern()
        {
            List<IEmployee> list1 = new List<IEmployee>();
            list1.Add(new Employee("Tom"));
            list1.Add(new Employee("Jerry"));
            list1.Add(new EmployeeAdapter("Bruno"));  //consultant from existing class
            ShowHappiness(list1);

            //*** Method to print execution results ***
            void ShowHappiness(List<IEmployee> list2)
            {
                foreach (IEmployee i in list2)
                    i.ShowHappiness();
            }
        }

        //LD_BRIDGE_000
        public static void RunBridgeStructuralPattern()
        {
                IAppliance tv = new TV("Bedroom TV");  //implementation object
                IAppliance vaccum = new VaccumCleaner("My Vaccum Cleaner");  //implementation object

                Switch s1 = GetSwitch(tv);  //convert to abstraction
                Switch s2 = GetSwitch(vaccum);  //convert to abstraction

                //*** client code works only with the abstraction objects, not the implementation objects ***
                s1.TurnOn();
                s2.TurnOn();

            //convert implementation object to abstraction object
            Switch GetSwitch(IAppliance a)
            {
                return new RemoteControl(a);
            }
        }




    }//LD end Program
}//LD close namespace
