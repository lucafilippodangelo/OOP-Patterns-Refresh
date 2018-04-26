# Facade
## Structural - Facade -  //LD_FACADE_000
### A single class that represents an entire subsystem

**This Pattern:** 
allows to provide a simplified interface from multiple class libraries. It provides a simple interface that hides the complexity of the class libraries being used. 

**Example**
For example, if the client code needs to access 3 different class libraries for a single functionality, instead of having the client code accessing those 3 class libraries, you can just create another class that calls the 3 class libraries and have the client access only the class that you have created. The result is a simplified interface for the client and the client will not need to know the details of the different class libraries.


**Main Resources**
- http://www.dotnetlead.com/design-patterns/facade