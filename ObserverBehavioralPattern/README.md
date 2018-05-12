# Observer
## Behavioral - Observer -  //LD_OBSERVER_000
### A way of notifying change to a number of classes

**When to use it**
 This pattern allows to have a publisher-subscriber framework where a change to a publisher will notify all of its subscribers automatically.  
 
 The subscribers are registered to the publisher so that when a change occurs in the publisher all of the subscribers are notified. 
 
 The publishers and the subscribers are decoupled through the use of interfaces so that the development of each can vary independently. 

**Key Points**
- //LDOBS001 The **ISubject** is the interface that all publishers implement and has the following properties and methods:
  - **observers** -- List of observers that listen to the changes in the subject
  - **Attach(IObserver)** -- Adds an observer to listen to changes in the subject
  - **Detach(IObserver)** -- Remove an observer from listening changes in the subject
  - **Notify()** -- Send updates to all the observers that subscribed to it
- //LDOBS002 The **ConcreteSubject** is the publisher class and it implements the ISubject interface. Besides the implementation of the ISubject interface it also has the subjectState variable:
  - **subjectState** -- the variable that represents the state of the subject
- //LDOBS003 The **IObserver** is the interface that all subscribers implement and has the Update method:
  - **Update()** -- update the subscriber and is called by the subject (publisher)
- //LDOBS004 The **ConcreteObserver** is the subscriber class and it implements the IObserver interface. Below are its variables and methods:
  - **observerState** -- the variable that represents the state of the observer
  - **Update()** -- update the state of the observer. Notice that the method simply assigns the observerState variable from the subject's state. Therefore when a change to the subject's state occurs, the observer's state will become the same as the subject's state.  

**Comparison with the mediator pattern**
A comparison between the mediator pattern and the observer pattern shows some similarities and some clear differences. Both patterns facilitates the communication between objects, and both decouples the link between the sender and the receiver. The main difference is that in the mediator pattern there is the notion of the participants and they communicate with each other using the mediator as a central hub, whereas in the observer pattern there is a clear distinction between the sender and the receiver, and the receiver merely listens to the changes in the sender.

### Main Resource
http://www.dotnetlead.com/design-patterns/observer











