# Decorator
## Structural - Decorator -  //LD_DECORATOR_000
### allows to add features to an object dynamically.

**When to use this Pattern:** 
An example would be the search functionality in an application. You may need to search for employees such as salary, zip code, skills, and so on. The user may choose to enter any combination of search criteria, and it would be a daunting task trying to figure out all the possible combination as the number of fields grow. The decorator pattern allows you to dynamically add only the fields that the user is searching for. 

**KEY**
In the decorator pattern each feature is represented by a class. Therefore if you have 10 features then you will have 10 decorator classes. 
- The **IComponent interface** defines the operation, or the features that the decorators can perform.
  - //LDDEC001
- The **StartComponent class** is the starting object that you can dynamically add features to. You will create this object first and add features to it.
  - //LDDEC002
- The **Decorator class** is an abstract class and is the parent class of all the decorators. While it implements the **IComponent interface** to define the operations, it also contains a **private variable input** that points to the object to be decorated. The input variable is simply assigned in the constructor.
  - //LDDEC003
- The **ConcreteDecorator class** are the actual decorator classes that can add features. You can have as many ConcreteDecorator class as you like, and each will represent a feature that can be added.
  - //LDDEC004
    - //LDDEC005 make the previous object do the decorations first
    - //LDDEC006 then add the implementation here to add the new feature

**Main Resources**
- http://www.dotnetlead.com/design-patterns/decorator