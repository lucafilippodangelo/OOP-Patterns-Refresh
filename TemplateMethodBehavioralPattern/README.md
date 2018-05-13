# Template Method
## Behavioral - Template Method -  //LD_TEMPLATEMETHOD_000
### Method	Defer the exact steps of an algorithm to a subclass

**When to use it**
This pattern allows you to declare a general logic at the parent class so that all the child classes can use the general logic.

The key to the template method pattern is that we put the general logic at the abstract parent class, and let the child class define the specifics.

**Key Points and Example**
In the example we will build 2 types of cars. One is a Porsche, the other is a VW Beetle.

- //LDTEM001 The **AbstractCarBuilder** class is the parent abstract class that contains the general logic.
  - It has the **BuildCar** method, this is the template method that contains the general logic, which specifies that it must build the skeleton of the car first, followed by the installation of the engine, and finally the installation of the doors.
  - It has the **BuildSkeleton**, **InstallEngine**, and **InstallDoor** method stubs for the child classes to implement.
- //LDTEM002,//LDTEM003 The **PorcheBuilder** and the **BeetleBuilder** classes are the child classes of the **AbstractCarBuilder**. Each of the child classes will specify how to build their own skeleton, the engine, and the doors.
  - It has the BuildSkeleton, InstallEngine, and InstallDoor methods that contains the actual implementation of the methods.

### Main Resource
http://www.dotnetlead.com/design-patterns/template-method












