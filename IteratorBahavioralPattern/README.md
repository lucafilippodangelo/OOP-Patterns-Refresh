# Iterator
## Behavioral - Iterator -  //LD_ITERATOR_000
### Sequentially access the elements of a collection

**When to use it**

this pattern allows to abstract out the details of traversing collections. 

For example, you may different types of collections in your applications, such as an array, a linked list, or a generic dictionary. For whichever the types of collections you have, you will need to traverse, or iterate through the items in the collections.  

The actual implementation on how to traverse different types of collections will be different, yet the client code(calling code) should not be concerned about the details of the implementations. 

The iterator pattern helps you to hide such details and provide a generic interface for the client to traverse different types of collections. 

**Key Points**
- //LDITE001 Client code
- //LDITE002 The **IIterator** interface defines all the methods needed to traverse the collection.                                  
- //LDITE003 The **ConcreteIterator** class implements the IIterator interface and has the actual implementations on how to traverse the collection.
- //LDITE004 The **IAggregate** interface defines the methods for the client. The methods that it defines allows the client code not to be bothered with the details on how the collection is traversed. It has the GetAll method that the client can call.
- //LDITE005 The **ConcreteAggregate** class implements the IAggregate interface and is the class that creates the ConcreteIterator.

### Main Resource
http://www.dotnetlead.com/design-patterns/iterator













