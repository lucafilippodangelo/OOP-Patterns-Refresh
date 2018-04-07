# Abstract Factory
### Creational - Abstract Factory

Provide an interface for creating families of related or dependent objects without specifying their concrete classes.
Abstract Factory is merely an extension of the factory method pattern, which allows to create objects without being concerned about the actual class of the objects being produced. 
The abstract factory pattern extends the factory method pattern by allowing more types of objects to be produced.

Description:
this project consists on some changes on the project https://github.com/lucafilippodangelo/OOP-Patterns-Refresh/tree/master/FactoryDesignPattern
I extend the factory method pattern to the abstract factory pattern by:                                                  
- Adding another product that the factories can produce. In this example we will add Advertisers that helps the bookstores advertise their stores online. 
- Each bookstore can then choose their own distributors and advertisers inside their own GetDistributor and GetAdvertiser method. 

//LDAF001 
declaration of a concrete factory, this decide the concrete element to instanciate.
So when the client goes in the shop and order a book, let the book store decide for who will be the distributor and the advertiser, depending on the customer location.

//LDAF002
The client order to a specific shop a book to be shipped and advertised.

//LDAF003, //LDAF004
The book is shipped and advertised, so we have the concrete products //LDAF005,//LDAF006

//LDAF007 - THE CORE
Notice that regardless if you pass in BookStoreA or BookStoreB into the method above, this client code does not need to be changed since it will get the correct advertiser automatically using the internal logics within the factories. It is the factories (BookStoreA and BookStoreB) that determines which advertiser to produce. The same goes for choosing which book distributor to produce.

The benefit of the Abstract Factory pattern is that it allows you to create a groups of products(the distributors and the advertisers) without having to know the actual class of the product being produced. The result is that you can have client code that does not need to be changed when  the internal logic of the factories on which product to produce changed.

### Resources:
- MAIN -> http://www.dotnetlead.com/design-patterns/abstract-factory
- http://www.dofactory.com/net/abstract-factory-design-pattern
