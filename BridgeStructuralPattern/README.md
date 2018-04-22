# Bridge
## Structural - Bridge -  //LD_BRIDGE_000
### Separates an object’s interface from its implementation

This design pattern allows to separate the abstraction from the implementation. In the bridge pattern there are 2 parts, the first part is the Abstraction, and the second part is the Implementation.  The bridge pattern allows the Abstraction and the Implementation to be developed independently, and the client code can access only the Abstraction part without being concerned about the Implementation part. 

Example:

**Abstraction:**
inside a house there are appliances that you can turn on or off, such as the floor lamp, the TV, and the vacuum cleaner. There are different ways to turn the appliance on or off, such as using the on/off switch, the pull switch, or using a remote control. 

//LDBRG001
The concept of turning the appliance on or off is the Abstraction part in the bridge pattern, and the user only needs to know the Abstraction part.


**Implementation:**

//LDBRG002
this part turns the appliance on or off. When the floor lamp,the TV, or the vacuum cleaner receives the signal to turn on or off, it uses its internal implementation to perform the action.  The user should not be bothered about **how** the appliance is turned on or off, and this is the key of the bridge design pattern. 

Notice that the client code uses only the Abstraction part to perform the actions, and you can develop the Abstraction and the Implementation parts independently

//LDBRG003
Concrete implementation of the action, we use an interface.

### Main Resource
http://www.dotnetlead.com/design-patterns/bridge













