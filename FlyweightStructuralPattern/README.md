# Flyweight
## Structural - Flyweight -  //LD_FLYWEIGHT_000
###  A fine-grained instance used for efficient sharing

**When to use this Pattern:** 

When I want reuse memory spaces in an application when I have lots of objects that are almost identical in nature. For example, if you are writing a game for a smartphone where the amount of memory is very limited and you need to show many aliens that are identical in shape, you can have only one place that holds the shape of the alien instead of keeping each identical shape in the precious memory. 

**KEY**

In the flyweight pattern there is the concept of **Intrinsic** and **Extrinsic** state. 
- //LDFLY001 **Intrinsic** states are things that are constant and are stored in the memory. 
- //LDFLY002 **Extrinsic** states are things that are not constant and needs to be calculated on the fly, and are therefore not stored in the memory.                                                                                                                  

For example, in the game that we would like to create, the shapes of the aliens are all the same, but their color will change based on how mad each are. The shapes of the aliens will be Intrinsic, and the color of the alien will be Extrinsic. 

**Example**
- //LDFLY003 The **AlienFactory class** stores and retrieves different types of aliens using its GetAlien and SaveAlien methods.
- //LDFLY004 The **IAlien interface** defines the shape property as the intrinsic state and the GetColor method as the extrinsic state.
- //LDFLY005 The **LargeAlien and the LittleAlien classes** are the **flyweight objects** where each has its own shape intrinsic state and ways of calculating the GetColor extrinsic state.

**Comparison with protorype pattern**

A comparison between the flyweight pattern and the prototype pattern shows some similarities in the UML, in that both uses a manager to store and retrieve the objects in the collection. But there is a clear difference between the two. The prototype pattern is used to create new objects that are similar in nature (hence it's a creational pattern), while the flyweight pattern is used to allow the application to point to the same instance of the object to save memory (hence it's a structural pattern).
- https://github.com/lucafilippodangelo/OOP-Patterns-Refresh/tree/master/PrototypeCreationalPattern


**Main Resources**

- http://www.dotnetlead.com/design-patterns/flyweight