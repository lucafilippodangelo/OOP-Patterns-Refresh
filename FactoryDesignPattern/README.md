# Factory
## Creational - Factory Method - //LD_FACTORY_000
### It is used to create objects. In this pattern, an interface is used for creating an object, but let subclass decide which class to instantiate.

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

