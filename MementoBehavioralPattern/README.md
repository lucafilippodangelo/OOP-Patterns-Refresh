# Memento
## Behavioral - Memento -  //LD_MEMENTO_000
### Capture and restore an object's internal state

**When to use it**
this pattern allows to save historical states of an object and restore the object back from the historical states

An example is: undo operations in a word processing application. 

**Key Points**
- //LDMEM001 The **Originator** class is the objects that will be saved and restored later:
  - //LDMEM001A The **state** variable contains information that represents the state of the Originator object. This is the variable that we save and restore.
  - //LDMEM001B The **CreateMemento** method is used to save the state of the Originator. It creates a Memento object by saving the state variable into the Memento object and return it. 
  - //LDMEM001C The **SetMemento** method restores the Originator by accepting a Memento object, unpackage it, and sets its state variable using the state variable from the Memento. This is for restoring the state of the Originator using the information that was previously saved in the Memento.
- //LDMEM002 The **Memento** class stores the historical information of the Originator. The information is stored in its state variable.
- //LDMEM003 The **Caretaker** class manages the list of Memento. This is the class for the client code to access.

**Note: ** the key to the Memento Design Pattern is that the client code will never access the Memento object, all of the interactions are done through the Caretaker class. The client code does not need to be concerned about how the states are stored and retrieved.


### Main Resource
http://www.dotnetlead.com/design-patterns/memento












