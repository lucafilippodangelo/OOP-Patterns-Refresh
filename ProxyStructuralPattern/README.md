# Proxy
## Structural - Proxy -  //LD_PROXY_000
### An object representing another object

**Description**

this pattern allows to provide an interface to other objects by creating a wrapper class as the proxy. The wrapper class, which is the proxy, can add additional functionality to the object of interest without changing the object's code.    

**When to use it**
- Adding security access to an existing object. The proxy will determine if the client can access the object of interest.
- Simplifying the API of complex objects. The proxy can provide a simple API so that the client code does not have to deal with the complexity of the object of interest.
- Providing interface for remote resources such as web service or REST resources.
- Coordinating expensive operations on remote resources by asking the remote resources to start the operation as soon as possible before accessing the resources.
- Adding a thread-safe feature to an existing class without changing the existing class's code.

**To recap**

the proxy is the object that is being called by the client to access the real object behind the scene.   

**Key Points**
- //LDPROXY001 The **ISubject** interface is the interface that both the **Proxy** class and the **RealSubject** class implements.
  - //LDPROXY002 It has the Operation method.
- //LDPROXY003 The **Proxy** class is the proxy for the **RealSubject** class.
  - //LDPROXY004 It has the **realSubject** variable that points to the real object behind the scene.
  - //LDPROXY005 It has the **Operation** method that encapsulate the real object's Operation method. This is the place where you can add additional logic to the real object's methods.
- //LDPROXY006 The **RealSubject** class is the real object behind the scene.
  - It has the **Operation** method that performs the actual work.

**Example**
- //LDPROXY001 The **ICar** interface is the interface that both the ProxyCar class and the Car interface implements.
  - //LDPROXY002 It has the MoveCar method.
- //LDPROXY003  The **ProxyCar** class is the proxy for the Car class.
  - //LDPROXY004 It has the **realCar** variable that points to the real object behind the scene.
  - //LDPROXY005  It has the **MoveCar** method that encapsulate the real object's MoveCar method. This is the place where we put in the additional logic to determine if the driver is over 16 years old. If the driver is not over 16 years old it will not call the real object's MoveCar method.
- //LDPROXY006 The **Car** class is the real object behind the scene.



### Main Resource
http://www.dotnetlead.com/design-patterns/proxy













