# Prototype
## Creational - Prototype
### A fully initialized instance to be copied or cloned

 This pattern allows to avoid expensive initialization routines when you construct objects that are very similar. 
 
 The goal is to minimize the amount of work needed in creating new objects when the initialization routines are expensive.
 
 **THE KEY:**
 The key to the prototype pattern is that you will create your first object with the expensive initializations, then store the values as a prototype in the repository. When you need create the same object again you can just get the copy of the prototype from the repository with all the values prepopulated.

 For example:
 if the initialization routine requires database queries, file lookups, or service calls and you already have other objects in the system that are very similar to the object you are constructing, then the prototype pattern may help you to avoid those expensive initializations. 

 - The **PrototypeManager** class is just a manager class that is used to add and retrieve prototypes by an index number
 - The **IPrototype** interface specifies the methods that all prototype classes must implement. It has the Clone method that returns an IPrototype interface.
 - The **ConcretePrototype** class is the actual prototype class, it implements the IPrototype interface and has the following property and method:
   - **copyProperty** variable holds the information that is prepopulated. If the variable value is changed then the new instances created will have the new value.
   - **Clone** method will make a copy of itself and return it. If the copyProperty is a value type (such as int or string) then you can just use shallow copy. If the copyProperty is a reference type (such as an object that contains other objects) then you will need to make deep copy of the variable.






















