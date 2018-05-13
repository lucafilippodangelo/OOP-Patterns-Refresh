# State
## Behavioral - State -  //LD_STATE_000
### Alter an object's behavior when its state changes

**When to use it**
This pattern allows to alter the behavior, or the state, of the object at runtime. 

Each behavior is represented by a state class, and the behavior can change from one state to another. 

**Key Points**
- //LDSTA001 The **IState** interface defines the behaviors that the states can handle.                     
  - It has the **Handle** method that specifies/define the behavior of the state **when an action is invoked**.
- //LDSTA002 The **ConcreteState** class are the classes that represents different behaviors. You will have multiple ConcreteState classes where each class will have its own implementation of behavior.
  - It has the **Handle** method that implements the state behavior, and it is within this method that you can change from one state to another.
- //LDSTA003 The **Context** class is the environment in which the states operates in.
  - It has the **Request** method that calls the IState's methods.

**KEY CONCEPT and comparison with Strategy pattern: ** 

A comparison between the UML of the state pattern and the strategy pattern shows striking similarities. 

Both pattern defines the behaviors as the concrete classes, and both pattern defines the context in which the behavior runs under. But there are clear differences. **The state pattern uses the behavior to switch to other behaviors**, while the strategy pattern lets the client code choose the behavior it needs.

### Main Resource
http://www.dotnetlead.com/design-patterns/state












