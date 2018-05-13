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
using CompositeStructuralPattern;
using DecoratorStructuralPattern;
using FacadeStructuralPattern;
using FlyweightStructuralPattern;
using ProxyStructuralPattern;
using ChainOfResponsabilityBehavioralPattern;
using CommandBehavioralPattern;
using InterpreterBehavioralPattern;
using IteratorBahavioralPattern;
using MementoBehavioralPattern;
using ObserverBehavioralPattern;
using StateBehavioralPattern;
using StrategyBehavioralPattern;
using TemplateMethodBehavioralPattern;

namespace PatternsRefresh
{
    public class Program
    {
        public static void Main(string[] args)
        {
            /*
            RunMediatorDesignPattern(); //LD_MEDIATOR_000
            RunSingletonCreationalPattern(); //LD_SINGLETON_000
            RunFactoryDesignPattern(); //LD_FACTORY_000
            RunAbstractFactoryDesignPattern(); //LD_ABSTRACT_FACTORY_000
            RunBuilderCreationalPattern(); //LD_BUILDER_000
            RunPrototypeCreationalPattern(); //LD_PROTOTYPE_000
            RunAdapterStructuralPattern(); //LD_ADAPTER_000
            RunBridgeStructuralPattern(); //LD_BRIDGE_000
            RunCompositeStructuralPattern(); //LD_COMPOSITE_000
            RunDecoratorStructuralPattern(); //LD_DECORATOR_000
            RunFacadeStructuralPattern(); //LD_FACADE_000
            RunFlyweightStructuralPattern(); //LD_FLYWEIGHT_000
            RunProxyStructuralPattern(); //LD_PROXY_000
            RunChainOfResponsabilityBehavioralPattern(); //LD_COR_000
            RunCommandBehavioralPattern(); //LD_COMMAND_000
            RunInterpreterBehavioralPattern(); //LD_INTERPRETER_000
            RunIteratorBehavioralPattern(); //LD_ITERATOR_000
            RunMementoBehavioralPattern(); //LD_MEMENTO_000
            RunObserverBehavioralPattern(); //LD_OBSERVER_000
            RunStateBehavioralPattern(); //LD_STATE_000
            RunStrategyBehavioralPattern(); //LD_STRATEGY_000
            RunTemplateMethodBehavioralPattern(); //LD_TEMPLATEMETHOD_000
*/
            RunVisitorBehavioralPattern(); //LD_VISITOR_000


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
            BuilderCreationalPattern.Director d = new BuilderCreationalPattern.Director();

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
            List<AdapterStructuralPattern.IEmployee> list1 = new List<AdapterStructuralPattern.IEmployee>();
            list1.Add(new Employee("Tom"));
            list1.Add(new Employee("Jerry"));
            list1.Add(new EmployeeAdapter("Bruno"));  //consultant from existing class
            ShowHappiness(list1);

            //*** Method to print execution results ***
            void ShowHappiness(List<AdapterStructuralPattern.IEmployee> list2)
            {
                foreach (AdapterStructuralPattern.IEmployee i in list2)
                    i.ShowHappiness();
            }
        }

        private static void ShowHappiness(List<AdapterStructuralPattern.IEmployee> list1)
        {
            throw new NotImplementedException();
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
                //LDBRG002
                //LD the concrete implementation of the abstraction, our RC gets in input the 
                // concrete appliance to manage. We could have many alternative to RC to manage applicances,
                // in any case I have to add just a new class with same approach as "RemoteControl.cs"
                return new RemoteControl(a); 
            }
        }

        //LD_COMPOSITE_000
        public static void RunCompositeStructuralPattern()
        {
            Worker a = new Worker("Worker Tom", 5);
            Supervisor b = new Supervisor("Supervisor Mary", 6);
            Supervisor c = new Supervisor("Supervisor Jerry", 7);
            Supervisor d = new Supervisor("Supervisor Bob", 9);
            Worker e = new Worker("Worker Jimmy", 8);

            //set up the relationships
            b.AddSubordinate(a); //Tom works for Mary
            c.AddSubordinate(b); //Mary works for Jerry
            c.AddSubordinate(d); //Bob works for Jerry
            d.AddSubordinate(e); //Jimmy works for Bob

            //"Jerry" shows his happiness and asks "mary" and "bob" to do the same
            if (c is CompositeStructuralPattern.IEmployee)
            {
                (c as CompositeStructuralPattern.IEmployee).ShowHappiness();
            }
        }

        //LD_DECORATOR_000
        public static void RunDecoratorStructuralPattern()
        {
            IComponent a = new PlainIceCream(); //LD starting point
            IComponent b = new CandyTopping(a); //LD pass in the IComponent that you want to decorate
            IComponent c = new PeanutTopping(b); //LD add another decorator (the "input" -> "b" will be a ref to "Candy" and then to "PlainIceCream")
            IComponent d = new NutsTopping(c); //LD add another decorator (the "input" -> "b" will be a ref to "Peanut" and then to "Candy" and then to "PlainIceCream") 
            d.AddTopping(); //LD do all the operations of AddTopping() of PlainIceCream, Candy, Peanuts, Nuts Toppings in one call
        }

        //LD_FACADE_000
        public static void RunFacadeStructuralPattern()
        {
            //LD  the client code only need to access the Facade class to gain the functionalities of the 3 class libraries
            Facade f = new Facade();
            f.DoSomething();
        }

        //LD_FLYWEIGHT_000
        public static void RunFlyweightStructuralPattern()
        {
            AlienFactory factory = new AlienFactory();
            factory.SaveAlien(0, new LargeAlien());
            factory.SaveAlien(1, new LittleAlien());

            //now access the flyweight objects
            IAlien a = factory.GetAlien(0);
            IAlien b = factory.GetAlien(1);

            //show intrinsic states, all accessed in memory without calculations
            Console.WriteLine("Showing intrinsic states...");
            Console.WriteLine("Alien of type 0 is " + a.Shape);
            Console.WriteLine("Alien of type 1 is " + b.Shape);

            //show extrinsic states, need calculations
            Console.WriteLine("Showing extrinsic states...");
            Console.WriteLine("Alien of type 0 is " + a.GetColor(0).ToString());
            Console.WriteLine("Alien of type 0 is " + a.GetColor(1).ToString());
            Console.WriteLine("Alien of type 1 is " + b.GetColor(0).ToString());
            Console.WriteLine("Alien of type 1 is " + b.GetColor(1).ToString());
        }

        //LD_PROXY_000
        public static void RunProxyStructuralPattern()
        {
            ICar car = new ProxyCar(new Driver(16));
            car.MoveCar();

            car = new ProxyCar(new Driver(25));
            car.MoveCar();
        }

        //LD_COR_000
        public static void RunChainOfResponsabilityBehavioralPattern()
        {
            /*
             Let's apply the pattern to an example. In a bank where the approval route for mortgage applications are 
             from the bank manager to the director then to the vice president, where the approval limits are:
               - Manager – 0 to 100k
               - Director – 100k to 250k
               - Vice President – anything above 250k
             We will pass the request to the manager until the application is processed

             Notice that the request is automatically processed by the correct person without the client code 
             having to determine who will process the request
             */

            LoanApprover a = new Manager();
            LoanApprover b = new ChainOfResponsabilityBehavioralPattern.Director();
            LoanApprover c = new VicePresident();

            //LD here I setup the hierarchy
            a.SetNextApprover(b);
            b.SetNextApprover(c);
       
            a.ApproveLoan(new Loan(50000));  //this will be approved by the manager
            a.ApproveLoan(new Loan(200000));  //this will be approved by the director
            a.ApproveLoan(new Loan(300000));  //this will be approved by the vice president
        }

        //LD_COMMAND_000
        public static void RunCommandBehavioralPattern()
        {
            //LDCOM005
            Invoker i = new Invoker();

            //save undo to position 100
            ICommand a = new UndoCommand(100);
            i.AddCommand(a);

            //save undo to position 200
            ICommand b = new UndoCommand(200);
            i.AddCommand(b);

            //perform the undo
            i.RunCommand();   //the client does not need to know about the details of the undo
        }

        //LD_INTERPRETER_000
        public static void RunInterpreterBehavioralPattern()
        {
            //LDINT001
            string tokenString = "+ - 10 2 3";

            /*tree representation
                 +
              -     3
            10 2
            */
            List<string> tokenList = new List<string>(tokenString.Split(' '));

            IExpression expression = new TokenReader().ReadToken(tokenList);
            Console.WriteLine(expression.Interpret());    // (10 - 2) + 3 = 11

            tokenString = "- + 10 5 - 8 2";
            tokenList = new List<string>(tokenString.Split(' '));

            expression = new TokenReader().ReadToken(tokenList);
            Console.WriteLine(expression.Interpret());   // (10 + 5) - (8 - 2) = 9 
        }

        //LD_ITERATOR_000
        public static void RunIteratorBehavioralPattern()
        {
            //LDITE001
            IAggregate<string> aggregate = new ConcreteAggregate<string>();

            aggregate.AddItem("Apple");    //add sample data
            aggregate.AddItem("Orange");
            aggregate.AddItem("Banana");
            aggregate.AddItem("Plum");

            //iterate through the collection using IAggregate only
            foreach (string i in aggregate.GetAll())
                Console.WriteLine(i);
        }

        //LD_MEMENTO_000
        public static void RunMementoBehavioralPattern()
        {
            Originator<string> orig = new Originator<string>();

            orig.SetState("state0");
            Caretaker<string>.SaveState(orig); //save state of the originator
            orig.ShowState();

            orig.SetState("state1");
            Caretaker<string>.SaveState(orig); //save state of the originator
            orig.ShowState();

            orig.SetState("state2");
            Caretaker<string>.SaveState(orig); //save state of the originator
            orig.ShowState();

            //restore state of the originator
            Caretaker<string>.RestoreState(orig, 0);
            orig.ShowState();  //shows state0
        }

        //LD_OBSERVER_000
        public static void RunObserverBehavioralPattern()
        {
            //one subject and two observers
            ISubject<string> subject = new ConcreteSubject<string>();
            ObserverBehavioralPattern.IObserver<string> observer1 = new ConcreteObserver<string>("observer1");
            ObserverBehavioralPattern.IObserver<string> observer2 = new ConcreteObserver<string>("observer2");

            //register the observers to the subject
            subject.Attach(observer1);
            subject.Attach(observer2);

            //a change to the subject automatically notifies all the observers
            subject.SetState("stateX");
        }

        //LD_STATE_000
        public static void RunStateBehavioralPattern()
        {
            Warrior w = new Warrior();
            w.ShowHealth();
            w.Battle();
            w.ShowHealth();
            w.Battle();
            w.ShowHealth();
            w.Battle();
            w.ShowHealth();
            w.Battle();
            w.ShowHealth();
        }

        //LD_STRATEGY_000
        public static void RunStrategyBehavioralPattern()
        {
            ChessGame game = new ChessGame();

            game.ComputerPlayer = new EasyComputerPlayer();
            game.Move();   //move using Easy difficulty

            game.ComputerPlayer = new MediumComputerPlayer();
            game.Move();   //move using Medium difficulty

            game.ComputerPlayer = new AdvancedComputerPlayer();
            game.Move();   //move using Advanced difficulty
        }

        //LD_TEMPLATEMETHOD_000
        public static void RunTemplateMethodBehavioralPattern()
        {
            AbstractCarBuilder c = new PorcheBuilder();
            c.BuildCar();

            c = new BeetleBuilder();
            c.BuildCar();
        }

        //LD_VISITOR_000
        public static void RunVisitorBehavioralPattern()
        { } 

    }//LD end Program
}//LD close namespace
