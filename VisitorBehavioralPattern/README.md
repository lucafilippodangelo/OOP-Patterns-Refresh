# Visitor
## Behavioral - Visitor -  //LD_VISITOR_000
### Defines a new operation to a class without change

**When to use it**
allows you to decouple the logics and the data structures and while applying the logics to the data structures. 

With this pattern you can build classes that focuses only on the data structures without knowing the logics that will be applied to the structure. 

At the same time, you can build classes that concentrate solely on the logics that will be applied to the structure without knowing what the structure looks like. 

The benefit is that the evolution of the logics and the structures can vary independently.

**Exercise and Key Points**
We will define 2 types of structures, Household and BusinessEntity. They are the data structures where the visitors can apply their logics to. Both the Household and the BusinessEntity can be visited by SantaClaus or the MailCarrier. 

- Classes for the **structures**
  - //LDVIS001 The **IElement** interface defines the elements in the structure.
    - It has the **Accept** method that takes in an IVisitor.
  - //LDVIS002 The **HouseHold** and the **BusinessEntity** class implements the IElement interface.
    - They have the **Accept** method that takes in an IVisitor that will apply the logic to the element.
- Classes for the **logics**
  - //LDVIS003 The **IVisitor** interface defines the logics supported.
    - It has the **Visit** method that takes in an **IElement**.
  - //LDVIS004 The **SantaClaus** and the **MailCarrier** class implements the **IVisitor** interface.
    - They have the **Visit** method that takes in an **IElement** that will apply the logic to the element.

Notice that you can develop the structure and the logic parts independently and yet you can easily apply the logics to the structures in the client code.

### Main Resource
http://www.dotnetlead.com/design-patterns/visitor












