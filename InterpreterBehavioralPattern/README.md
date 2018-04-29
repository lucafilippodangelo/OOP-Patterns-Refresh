# Interpreter
## Behavioral - Interpreter -  //LD_INTERPRETER_000
### A way to include language elements in a program

**When to use it**
this pattern allows to build the rules as classes.

This design pattern is very powerful in building the rules in a very logical manner, is possible apply the rules to any streams of inputs or objects.

**Exercise**

We evaluate the input expressions by reading a tree from the left:
- Example 1:
  - Expression = (10 - 2) + 3 = (SubtractExpression) + NumberExpression = Expression + Expression = AddExpression = 11
  - tree representation
      +
    -   3
  10 2

- Example 2:
  - Expression = (10 + 5) - (8 - 2) = (AddExpression) - (SubtractExpression) = Expression - Expression = SubtractExpression = 9

**Key Points**
- //LDINT001 the client code define a string need to be interpred
- //LDINT002 The **IExpression** interface requires all expression classes to have the Interpret method, which means that all expressions can be interpreted.
- //LDINT003 The **NumberExpression** class implements the IExpression interface, and since it's just a representation of a number it does not contain other expressions. Expressions that does not contain other expressions are called the TerminalExpressions. 
- //LDINT004, //LDINT005 The **AddExpression** and **SubtractExpression** class implements the IExpression interface and contains other expressions. Expressions that contains other expressions are called the NonTerminalExpressions. 

### Main Resource
http://www.dotnetlead.com/design-patterns/interpreter













