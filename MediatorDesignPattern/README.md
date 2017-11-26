Mediator Design Pattern:
This pattern allows multiple objects to communicate with each other’s without knowing each other’s structure. This pattern defines an object which encapsulates how the objects will interact with each other’s and supports easy maintainability of the code by loose coupling.

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