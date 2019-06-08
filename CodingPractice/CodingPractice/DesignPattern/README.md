
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


### Abstract Factory Pattern


In Abstract Factory we define an interface which will create families of related or dependent objects. In simple words, interface will expose multiple methods each of which will create some object. Again, here method return types will be generic interfaces. All this objects will together become the part of some important functionality.

Question – If every factory is going to create multiple objects and all those objects will be related to each other (means they will use each other) how this relating happens and who does that?

Answer –

There will be an intermediary class which will have composition relationship with our interface.
This class will do all the work, using all the objects got from interface methods.
This will be the class with which client will interact.
