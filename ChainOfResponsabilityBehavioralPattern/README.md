# Chain Of Responsability
## Behavioral - Chain Of Responsability -  //LD_COR_000
### A way of passing a request between a chain of objects

**When to use it**
this pattern allows to pass a request to from an object to the next until the request is fulfilled.  For example, you can pass a mortgage application request to a bank manager, and if the manager cannot approve the loan, it can be passed to his supervisor and so on. The chain of responsibility automates the passing of requests from one object to the next. 

**Key Points**
- //LDCOR001 The **Handler** class is the parent abstract class for all the objects that can handle requests:
  - //LDCOR002 The protected **nextHandler** variable is a reference that points to the next handler. If the request cannot be processed by the object it will be passed to the nextHandler for processing.                                                                                                        
  - //LDCOR003 The **SetNextHandler** method simply assigns the nextHandler variable.                                    
  - //LDCOR004 The **ProcessRequest** method is the method signature that all child classes must implement.
- //LDCOR005 The **ConcreteHandler** are the concrete child classes that handles the requests. In its ProcessRequest method it checks to see if it can process the request, if yes it will process the request and return, if not the request will be passed to the next handler. This logic is repeated until the request is fulfilled.

**Example**



### Main Resource
http://www.dotnetlead.com/design-patterns/proxy













