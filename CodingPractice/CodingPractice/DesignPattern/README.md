
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

<p name="abstractfactory"></p>

In Abstract Factory we define an interface which will create families of related or dependent objects. In simple words, interface will expose multiple methods each of which will create some object. Again, here method return types will be generic interfaces. All this objects will together become the part of some important functionality

#### Problem Statement

A shop has selling the computer spare parts and their business not going well as expected as people are no longer buyig the spare parts . So he decided to assemble the computer and sell it to customer based on their needs i.e low budget , high budget and medium budjet.
He asked his employee to build a product with the budget. So they strated preparting computer with pre defined configuration. 
In computer keyboard, ram, hard disk consider as a product(Factory) and it can be configured based on the budget and make CPU as a final  product(Abstract)


