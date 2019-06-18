

<p name="creational"></p>


## Creational Patterns 
- Abstract Factory  
   - Creates an instance of several families of classes
- Builder
   - Separates object construction from its representation
- Factory Method
  - Creates an instance of several derived classes
- Prototype
   - A fully initialized instance to be copied or cloned
- Singleton
   - A class of which only a single instance can exist

<p name="factory"></p>

### Factory Method 
The Factory Method Pattern, suited for this situation, defines an interface for creating an object, but let subclasses decide which
        class to instantiate. Factory Method lets a class defer instantiation to subclasses.
   
   [Source code](https://github.com/senthil338/coding_interview/blob/master/CodingPractice/CodingPractice/DesignPattern/FactoryDesign.cs)

#### Problem Statement

In today’s modern world, everyone is using software to facilitate their jobs. Recently, a product company has shifted the way
they used to take orders from their clients. The company is now looking to use an application to take orders from them. They
receive orders, errors in orders, feedback for the previous order, and responses to the order in an XML format. The company has
asked you to develop an application to parse the XML and display the result to them.
The main challenge for you is to parse an XML and display its content to the user. There are different XML formats depending
on the different types of messages the company receives from its clients. Like, for example, an order type XML has different sets
of xml tags as compared to the response or error XML. But the core job is the same; that is, to display to the user the message
being carried in these XMLs.    


Although the core job is the same, the object that would be used varies according to the kind of XML the application gets from
the user. So, an application object may only know that it needs to access a class from within the class hierarchy (hierarchy of
different parsers), but does not know exactly which class from among the set of subclasses of the parent class is to be selected.
In this case, it is better to provide a factory, i.e. a factory to create parsers, and at runtime a parser gets instantiated to do the job,
according to the kind of XML the application receives from the user.
The Factory Method Pattern, suited for this situation, defines an interface for creating an object, but let subclasses decide which
class to instantiate. Factory Method lets a class defer instantiation to subclasses.


<p name="abstractfactory"></p>

### Abstract Factory Pattern

In Abstract Factory we define an interface which will create families of related or dependent objects. In simple words, interface will expose multiple methods each of which will create some object. Again, here method return types will be generic interfaces. All this objects will together become the part of some important functionality

[Source code](https://github.com/senthil338/coding_interview/blob/master/CodingPractice/CodingPractice/DesignPattern/AbstractFactory.cs)

#### Problem Statement

A shop has selling the computer spare parts and their business not going well as expected as people are no longer buyig the spare parts . So he decided to assemble the computer and sell it to customer based on their needs i.e low budget , high budget and medium budjet.
He asked his employee to build a product with the budget. So they strated preparting computer with pre defined configuration. 
In computer keyboard, ram, hard disk consider as a product(Factory) and it can be configured based on the budget and make CPU as a final  product(Abstract)

<p name="behavioral"></p>

## Behavioral Patterns


- Chain of responsibility
   - A way of passing a request between a chain of objects
- Command
   - Encapsulate a command request as an object
- Interpreter
   - A way to include language elements in a program
- Iterator
   - Sequentially access the elements of a collection
- Mediator
   - Defines simplified communication between classes
- Memento
   - Capture and restore an object's internal state
- Null Object
   - Designed to act as a default value of an object
- Observer
   - A way of notifying change to a number of classes
- State
   - Alter an object's behavior when its state changes
- Strategy
   - Encapsulates an algorithm inside a class
- Template method
   - Defer the exact steps of an algorithm to a subclass
- Visitor
   - Defines a new operation to a class without change

<p name="observer"></p>


### Observer Pattern

The Observer Pattern is a kind of behavior pattern which is concerned with the assignment of responsibilities between objects.
The behavior patterns characterize complex control flows that are difficult to follow at run-time

[Source code](https://github.com/senthil338/coding_interview/blob/master/CodingPractice/CodingPractice/DesignPattern/ObserverPattern.cs)
 
#### Problem Statement

Sports Lobby is a fantastic sports site for sport lovers. They cover almost all kinds of sports and provide the latest news,
information, matches scheduled dates, information about a particular player or a team. Now, they are planning to provide live
commentary or scores of matches as an SMS service, but only for their premium users. Their aim is to SMS the live score, match
situation, and important events after short intervals. As a user, you need to subscribe to the package and when there is a live
match you will get an SMS to the live commentary. The site also provides an option to unsubscribe from the package whenever
you want to.   
As a developer, the Sport Lobby asked you to provide this new feature for them. The reporters of the Sport Lobby will sit in
the commentary box in the match, and they will update live commentary to a commentary object. As a developer your job is to
provide the commentary to the registered users by fetching it from the commentary object when it’s available. When there is an
update, the system should update the subscribed users by sending them the SMS.
This situation clearly shows one-to-many mapping between the match and the users, as there could be many users to subscribe to
a single match. The Observer Design Pattern is best suited to this situation, let’s see about this pattern and then create the feature
for Sport Lobby.    

<p name="structural"></p>

## Structural Patterns

- Adapter
   - Match interfaces of different classes
- Bridge
   - Separates an object’s interface from its implementation
- Composite
   - A tree structure of simple and composite objects
- Decorator
   - Add responsibilities to objects dynamically
- Facade
   - A single class that represents an entire subsystem
- Flyweight
   - A fine-grained instance used for efficient sharing
- Private Class Data
   - Restricts accessor/mutator access
- Proxy
   - An object representing another object

<p name="adapter"></p>


### Adapter
It allows the interface of an existing class to be used as another interface. It is often used to make existing classes work with others without modifying their source code.   

[Source code](https://github.com/senthil338/coding_interview/blob/master/CodingPractice/CodingPractice/DesignPattern/AdapterPattern.cs)

#### Problem Statement
A software developer, Max, has worked on an e-commerce website. The website allows users to shop and pay online. The site
is integrated with a 3rd party payment gateway, through which users can pay their bills using their credit card. Everything was
going well, until his manager called him for a change in the project.
The manager told him that they are planning to change the payment gateway vendor, and he has to implement that in the
code.
The problem that arises here is that the site is attached to the Xpay payment gateway which takes an Xpay type of object. The
new vendor, PayD, only allows the PayD type of objects to allow the process. Max doesn’t want to change the whole set of 100
of classes which have reference to an object of type XPay. This also raises the risk on the project, which is already running on the
production. Neither he can change the 3rd party tool of the payment gateway. The problem has occurred due to the incompatible
interfaces between the two different parts of the code. In order to get the process work, Max needs to find a way to make the
code compatible with the vendor’s provided API. Now, the current code interface is not compatible with the new vendor’s interface.

<p name="facade"></p>


### Facade Pattern

The Facade Pattern makes a complex interface easier to use, using a Facade class. The Facade Pattern provides a unified interface
to a set of interface in a subsystem. Facade defines a higher-level interface that makes the subsystem easier to use.

[Source code](https://github.com/senthil338/coding_interview/blob/master/CodingPractice/CodingPractice/DesignPattern/Facade.cs)

#### Problem Statement
Your company is a product based company and it has launched a product in the market, named Schedule Server. It is a kind
of server in itself, and it is used to manage jobs. The jobs could be any kind of jobs like sending a list of emails, sms, reading
or writing files from a destination, or just simply transferring files from a source to the destination. The product is used by the
developers to manage such kind of jobs and able to concentrate more towards their business goal. The server executes each job
at their specified time and also manages all underline issues like concurrency issue and security by itself. As a developer, one
just need to code only the relevant business requirements and a good amount of API calls is provided to schedule a job according
to their needs.
Everything was going fine, until the clients started complaining about starting and stopping the process of the server. They said,
although the server is working great, the initializing and the shutting down processes are very complex and they want an easy
way to do that. The server has exposed a complex interface to the clients which looks a bit hectic to them.
We need to provide an easy way to start and stop the server.    
A complex interface to the client is already considered as a fault in the design of the current system. But fortunately or unfortunately, we cannot start the designing and the coding from scratch. We need a way to resolve this problem and make the interface
easy to access.    
The problem faced by the clients in using the Schedule Server is the complexity brought by the server in order to start and stop
its services. The client wants a simple way to do it. A Facade Pattern can help us to resolve this design problem.    



