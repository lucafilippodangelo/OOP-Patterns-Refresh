# Adapter
## Structural - Adapter - //LD_ADAPTER_000
### Match interfaces of different classes
	
The Adapter Design Pattern allows you to make an **existing class work with other existing class libraries** without changing the code of the existing class. 

**Explanation:**
We often need to use the methods of an existing class to work with other existing libraries. The way to do this is by creating another class, named the Adapter, that inherits from the existing class while implementing the interface of the existing library. The end result is that the Adapter can call the method of the existing class (since the Adapter inherits from the existing class) and can work in the existing library (since the Adapter implements the interface of the existing library).

- The **Adaptee** is the existing class.
- The **IInterface** is the interface defined in the existing library.     
- The Adapter is the class that you create, it is inherited from the Adaptee class and it implements the IInterface interface. Notice that it can call the **OperationA** method(inherited from the Adaptee) inside its **OperationB** method(implemented by the IInterface).

**Example**
//LDADP001
You are then given the **Consultant class**,and you need to plug this Consultant class into the **organization tree**. The Consultant class is the Adaptee.

//LDADP002
The way to do this is by creating the adapter class named the **EmployeeAdapter**, that inherits from the Consultant class while it implements the IEmployee interface.

//LDADP003
In the Adapter we can then call the methods from the parent class to mimic the behaviors needed in the common interface. 
- In the EmployeeAdapter class we can call the ShowSmile method from the parent Consultant class in its implementation of the IEmployee interface, which requires the ShowHappiness method.

**KEY:**
Notice that we don't need to change the existing code in the Consultant class, yet we can plug its functionality into the existing IEmployee interface


**Main Resources:**
- http://www.dotnetlead.com/design-patterns/adapter















