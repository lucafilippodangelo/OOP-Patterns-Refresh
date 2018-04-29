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

### Main Resource
http://www.dotnetlead.com/design-patterns/proxy













