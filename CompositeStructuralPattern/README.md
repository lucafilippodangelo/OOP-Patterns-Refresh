# Composite
## Structural - Composite -  //LD_COMPOSITE_000
### A tree structure of simple and composite objects

**This Pattern** allows you to set up a tree structure and ask each element in the tree structure to perform a common task. 

A typical tree structure would be a company organization chart, where the CEO is at the top and other employees at the bottom. After the tree structure is established you can then ask each element, or employee, to perform a common operation. 

Each element in the tree can be a "leaf" or a "composite"(parent od leafs)
- The **IComponent interface** defines the methods that both the Composite class and the Leaf class must implement. The **Operation method** is the common method that all elements in the tree structure can perform. The **IComponent** simply represents an element in the tree.
- The **Leaf class** are elements that cannot have any elements below it, and it only has Operation method to perform the task for the element.
  - //LDCMP001
- The **Composite class** are elements that can have 0 or more elements below it. The methods that it supports are as follows:
  - //LDCMP002
    - The **AddComponent method** adds an element below it
    - The **GetChild method** gets all the elements below it
    - The **Operation method** performs the task for the element itself
    - The **RemoveComponent method** deletes an element below it

**Exercise Notes**
When you call a supervisor's ShowHappiness method, it will show both the supervisor’s happiness and all of its subordinate’s happiness by calling each of the subordinate's ShowHappiness method.

The key to the composite design pattern is that it allows you to set up a structure with a common operation (such as the ShowHappiness method), and then you can have all the elements to perform the common operation. This is done by keeping a list of child elements that implements the common interface in the composite class, and then calling each child element's operations.



**Main Resources**
- http://www.dotnetlead.com/design-patterns/composite