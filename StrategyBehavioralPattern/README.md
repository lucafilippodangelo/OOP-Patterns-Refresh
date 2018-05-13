# Strategy
## Behavioral - Strategy -  //LD_STRATEGY_000
### Encapsulates an algorithm inside a class

**When to use it**
This pattern  allows to change the behavior of an application when given a context. 

The context is the outer shell the client code calls, and the behavior are defined by the strategy classes. 

The strategy pattern allows you to decouple the outer context from the internal behaviors. 

Each behavior is represented by a state class, and the behavior can change from one state to another. 

**Key Points**
- //LDSTR001 The **IStrategy** interface defines the behaviors supported.                  
  - It has the **Algorithm** method that specifies the behavior/action. 
- //LDSTR002 The **ConcreteStrategy** class are classes that implements the behaviors. You will have multiple ConcreteStrategy classes where each class implements a behavior.
  - It has the **Algorithm** method that implements the behavior.
- //LDSTR003 The **Context** class defines the situation to use the behaviors.
  - It has the **strategy** variable that points to the behavior of the Context. 

**The benefit of the strategy pattern is it allows you to choose the behavior of the application at runtime. You only need to define the behaviors as strategy classes, and the client code can simply choose any of the classes to exhibit the behavior.**

**Comparison with state pattern**

A comparison between the UML of the strategy pattern and the state pattern shows striking similarities. Both pattern defines the behaviors as the concrete classes, and both pattern defines the context in which the behavior runs under. But there are clear differences. The **strategy pattern lets the client code choose the behavior it needs**, while the state pattern uses the behavior to switch to other behaviors. 

### Main Resource
http://www.dotnetlead.com/design-patterns/strategy












