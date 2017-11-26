Mediator Design Pattern:
This pattern allows multiple objects to communicate with each other’s without knowing each other’s structure. This pattern defines an object which encapsulates how the objects will interact with each other’s and supports easy maintainability of the code by loose coupling.

Project Structure:
IMediator
  - This is an interface that defines operations which can be called by colleague objects for communication.

Mediator
  - This is a class that implement the communication operations of the Mediator interface.

ColleagueAbstract
  - This is a class that defines a single, protected field that holds a reference to a mediator.

Colleague One/Two
  - These are the classes that communicate with each other via the mediator.

Execution of the test:
//LD STEP006