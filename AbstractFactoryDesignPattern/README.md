# Builder
## Creational - Builder -  //LD_BUILDER_000
### Separates object construction from its representation

This creational pattern allows to create a general guideline on how to create an object, then have different implementations on how to build parts of the object. 

There are 2 principles in the builder pattern, let's use an example of building an airplane to demonstrate the principles:- 
- //LDB001 PRIORITY -> The first principle is the general guideline that must be followed when building an object. For example, in building an airplane the body must be constructed before the wings. This general guideline must be followed regardless what types of airplane you are building. 
- //LDB002, //LDB003 SPECIFICATIONS -> The second principle are the different specifications on building the parts of the airplane. When building a jet airplane the body must be built differently than a propeller airplane. These specifications are included in the pattern.  

The **Client code** is just //LDB004

### Resources:
- http://www.dotnetlead.com/design-patterns/builder