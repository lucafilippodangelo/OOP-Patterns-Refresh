Mediator Design Pattern:
This pattern allows multiple objects to communicate with each other’s without knowing each other’s structure. 
The mediator pattern is a behavioral design pattern that promotes loose coupling between objects and helps to organize the code for inter-object communications.

Imagine an application in which there are many objects that are communicating with each other. The mediator design pattern is useful when the number of objects grows so large that it becomes difficult to maintain the references to the objects. The mediator is essentially an object that encapsulates how one or more objects interact with each other. The mediator design pattern controls how these objects communicate, and helps to reduce the number of dependencies among them that you have to manage.

Project Structure:
IMediator
  - This is an interface that defines operations which can be called by colleague objects for communication.
  - //LD STEP001 the Mediator has the ability to send the specific message "msg" created by a caller. The caller will be a concrete "Colleague"

Mediator
  - This is a class that implement the communication operations of the Mediator interface.
  - //LD STEP002 the concrete "Mediator" has referiment to the objects that need to communicate
  - //LD STEP003 the concrete "Mediator" cointain the logic to distribute the messages

ColleagueAbstract
  - This is a class that defines a single, protected field that holds a reference to a mediator.
  - //LD STEP004 this class has a reference to the "Mediator"

Colleague One/Two/Three
  - These are the classes that communicate with each other via the mediator.
  - //LD STEP005 any concrete "Colleague" class can "Send" and "Receive" messages from the "Mediator". The class use a referement to "Mediator" 

Execution of the test:
  - //LD STEP006

Example to Implement in .net Core --> https://www.stevejgordon.co.uk/cqrs-using-mediatr-asp-net-core