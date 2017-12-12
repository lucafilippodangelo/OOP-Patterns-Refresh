[Creational] Factory Design Pattern:
It is used to create objects.
In Factory pattern, we create object without exposing the creation logic. 
In this pattern, an interface is used for creating an object, but let subclass 
decide which class to instantiate.

The benefit is that the client code(calling code) can just say "give me an object that 
can do XYZ" without knowing what is the actual class that can do "XYZ". 

EXAMPLE:
the factory method that returns a product(a distributor).  Each of the distributor implements 
the IDistributor interface, which has the ShipBook method. The client code just say 
"give me a distributor that can ShipBook" without having to know which distributor you 
are going to return.

RESOURCE
http://www.dofactory.com/net/factory-method-design-pattern
http://www.dotnetlead.com/design-patterns/factory-method