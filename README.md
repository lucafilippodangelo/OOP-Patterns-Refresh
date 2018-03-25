# Patterns Refresh
Real reason why I'm implementing this is to remember that patterns are not just for interviews!

This project to refresh a set of probable working solutions for particular recurring problems.

**Note** Download the full solution and search by labels as "//LD_MEDIATOR_002" to match description and code.

## CREATIONAL patterns - Creation of objects and classes

### -> Creational - Abstract Factory
Abstract Factory, Creates an instance of several families of classes

### -> Creational - Builder
Separates object construction from its representation

### -> Creational - Factory Method - //LD_FACTORY_000
It is used to create objects.
In this pattern, an interface is used for creating an object, but let subclass 
decide which class to instantiate.

The benefit is that the client code(calling code) can just say "give me an object that 
can do XYZ" without knowing what is the actual class that can do "XYZ". 

Example:
the factory method that returns a product(a distributor).  Each of the distributor implements 
the IDistributor interface, which has the ShipBook method. The client code just say 
"give me a distributor that can ShipBook" without having to know which distributor you 
are going to return.

Project Structure:
- //LDF001 The flow starts from here, the abstraction of the objects to create.
- //LDF002 client code does not need to be changed if the logic for choosing the distributor in each BookStore will change
- //LDF003 the client code don’t need to care which distributor is being created, and this is the key to the factory method pattern.

Resources:
- http://www.dofactory.com/net/factory-method-design-pattern
- http://www.dotnetlead.com/design-patterns/factory-method

### -> Creational - Prototype
A fully initialized instance to be copied or cloned

### -> Creational - Singleton - //LD_SINGLETON_000
Ensure a class has only one instance and provide a global point of access to it.
Singleton pattern creates a class which can have a single object throughout the application, so that whenever any other object tries to access the object of the class, it will access the same object always.

## STRUCTURAL Patterns - Class and Object Composition

### -> Structural - Adapter
Match interfaces of different classes

### -> Structural - Bridge
Separates an object’s interface from its implementation

### -> Structural - Composite
A tree structure of simple and composite objects

### -> Structural - Decorator
Add responsibilities to objects dynamically

### -> Structural - Facade
A single class that represents an entire subsystem

### -> Structural - Flyweight
A fine-grained instance used for efficient sharing

### -> Structural - Proxy
An object representing another object

## BEHAVIORAL Patterns - Communication between class and objects

### -> Behavioral- Chain of Responsability
A way of passing a request between a chain of objects

### -> Behavioral- Command
Encapsulate a command request as an object

### -> Behavioral- Interpreter
A way to include language elements in a program

### -> Behavioral- Iterator
Sequentially access the elements of a collection

### -> Behavioral- Mediator //LD_MEDIATOR_000
This pattern allows multiple objects to communicate with each other’s without knowing each other’s structure. 
The mediator pattern is a behavioral design pattern that promotes loose coupling between objects and helps to organize the code for inter-object communications.

Imagine an application in which there are many objects that are communicating with each other. The mediator design pattern is useful when the number of objects grows so large that it becomes difficult to maintain the references to the objects. The mediator is essentially an object that encapsulates how one or more objects interact with each other. The mediator design pattern controls how these objects communicate, and helps to reduce the number of dependencies among them that you have to manage.

Project Structure:
IMediator
  - This is an interface that defines operations which can be called by colleague objects for communication.
  - //LD_MEDIATOR_001 the Mediator has the ability to send the specific message "msg" created by a caller. The caller will be a concrete "Colleague"

Mediator
  - This is a class that implement the communication operations of the Mediator interface.
  - //LD_MEDIATOR_002 the concrete "Mediator" has referiment to the objects that need to communicate
  - //LD_MEDIATOR_003 the concrete "Mediator" cointain the logic to distribute the messages

ColleagueAbstract
  - This is a class that defines a single, protected field that holds a reference to a mediator.
  - //LD_MEDIATOR_004 this class has a reference to the "Mediator"

Colleague One/Two/Three
  - These are the classes that communicate with each other via the mediator.
  - //LD_MEDIATOR_005 any concrete "Colleague" class can "Send" and "Receive" messages from the "Mediator". The class use a referement to "Mediator" 

Execution of the test:
  - //LD_MEDIATOR_006

Example to Implement in .net Core --> https://www.stevejgordon.co.uk/cqrs-using-mediatr-asp-net-core

### -> Behavioral- Memento
Capture and restore an object's internal state

### -> Behavioral- Observer
A way of notifying change to a number of classes

### -> Behavioral- State
Alter an object's behavior when its state changes

### -> Behavioral- Strategy
Encapsulates an algorithm inside a class

### -> Behavioral- Template Method
Method	Defer the exact steps of an algorithm to a subclass

### -> Behavioral- Visitor
Defines a new operation to a class without change
