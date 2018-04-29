# Command
## Behavioral - Command -  //LD_COMMAND_000
### Encapsulate a command request as an object

**When to use it**

this pattern allows to store a list of actions that you can execute later. 
A common example is storing the **undo actions** in an application. The undo actions are stored as the user is making changes in an application. When the user decides to perform the undo, the undo actions are retrieved and executed.

The **benefit** of the command pattern is that it hides the details of the actions that needs to be performed, so that the client code does not need to be concerned about the details when it needs to execute the actions. The client code just need to tell the application to execute the command that was stored.  

**Key Points**

The **client code** (calling code) will used the **Invoker** to run the commands, where the **Command** objects will call the **Receiver** to perform the action. 

The benefit is that the client code does not need to know what is stored in the Command objects nor the actions that will be performed by the Receiver, and this is the key of the Command Design Pattern.

- //LDCOM001 The **ICommand** interface defines the methods that all Command classes must implement.                       
- //LDCOM002 The **Command** class stores the details of the actions that need to be performed (the location of position Y and position X for the undo).
  - The UndoCommand class stores the location where the rectangle is supposed to move back.
- //LDCOM003 The **Receiver** class performs the action when called upon (moving the rectangle from position Y back to position X).
  - The UndoPerformer will move the rectangle back to its original position, taking the UndoCommand as the parameter.
- //LDCOM004 The **Invoker** class stores the list of commands and can ask the ICommand to execute.
  - The Invoker stores the list of undo commands.
- //LDCOM005 The **Client** class uses the Invoker to run the commands.

### Main Resource
http://www.dotnetlead.com/design-patterns/command













