# Builder
## Creational - Builder -  //LD_BUILDER_000
### Separates object construction from its representation

This creational pattern allows to create a general guideline on how to create an object, then have different implementations on how to build parts of the object. 

There are 2 principles in the builder pattern, let's use an example of building an airplane to demonstrate the principles:- 
- //LDB001 PRIORITY -> The first principle is the general guideline that must be followed when building an object. For example, in building an airplane the body must be constructed before the wings. This general guideline must be followed regardless what types of airplane you are building. 
- //LDB002, //LDB003 SPECIFICATIONS -> The second principle are the different specifications on building the parts of the airplane. When building a jet airplane the body must be built differently than a propeller airplane. These specifications are included in the pattern.  

The **Client code** is just //LDB004

The key to the builder pattern is:

You only need to determine the sequence in which the product (the airplane) is constructed in the Director
You can have different implementation of the manufacturers on how the parts of an object (the body and the wings) are constructed
The benefit of the builder pattern is that you can swap out any implementations on how the parts are built by changing the manufactures, and the rest of the client code will not need to be changed.

In application frameworks today we often see the builder pattern being utilized. For example, you may have multiple configuration files that have information on database services, file location services, and notification services. These configuration files would be your manufactures, where each have their own specifications on how each part of the configuration object should be built. The director would specify the way to read the configuration file, for example you may need to read the database services first before you read the notification services.

### Resources:
- http://www.dotnetlead.com/design-patterns/builder