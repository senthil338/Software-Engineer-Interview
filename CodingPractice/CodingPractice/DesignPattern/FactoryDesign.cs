using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.DesignPattern
{
#region Factory Example code for GitHub post
    #region 1. Product interface or abstract class
    public interface XMLParser
    {
        string parse();
    }
    #endregion

    #region 2. ConcreteProduct like different type of xmlParser  which implement common product behavior
    public class ErrorXMLParser : XMLParser
    {
        public string parse()
        {
            Console.WriteLine("Parsing error XML...");
            return "Error XML Message";
        }
    }
    public class FeedbackXML : XMLParser
    {

        public String parse()
        {
            Console.WriteLine("Parsing feedback XML...");
            return "Feedback XML Message";
        }
    }
    public class OrderXMLParser : XMLParser
    {

        public String parse()
        {
            Console.WriteLine("Parsing order XML...");
            return "Order XML Message";
        }
    }
    public class ResponseXMLParser : XMLParser
    {
        public String parse()
        {
            Console.WriteLine("Parsing response XML...");
            return "Response XML Message";
        }
    }
    #endregion
    #region 3. Creator -> interface or abstract class for concreate class interface whihc are implemented by Product 
    public abstract class DisplayService
    {
        public void display()
        {
            XMLParser parser = getParser();
            String msg = parser.parse();
            Console.WriteLine(msg);
        }
        protected abstract XMLParser getParser();

    }
    #endregion

    #region 4. ConcreteCreator , implement creator
    public class ErrorXMLDisplayService : DisplayService
    {
        protected override XMLParser getParser()
        {
            return new ErrorXMLParser();
        }
    }
    public class FeedbackXMLDisplayService : DisplayService
    {
        protected override XMLParser getParser()
        {
            return new FeedbackXML();
        }
    }
    
    public class OrderXMLDisplayService : DisplayService
    {
        protected override XMLParser getParser()
        {
            return new OrderXMLParser();
        }
    }

    public class DisplayFactoryService
    {
        public DisplayService ParseXML(XMLTypes xmlTypes)
        {
            switch (xmlTypes)
            {
                case XMLTypes.OrderXML:
                    return new OrderXMLDisplayService();
                case XMLTypes.FeedbackXML:
                    return new FeedbackXMLDisplayService();
                case XMLTypes.ErrorXML:
                    return new ErrorXMLDisplayService();
                default:
                    throw new ApplicationException("XML cannot be created");
            }
            
        }

    }
    #endregion
    public enum XMLTypes
    {
        OrderXML,
        ErrorXML,
        FeedbackXML

    }
    #endregion

#region 2nd Example
    public class FactoryMethod
    {

        /*
         1. Product - This is an interface for creating the objects.
         2. ConcreteProduct - This is a class which implements the Product interface.
         3. Creator - This is an abstract class and declares the factory method, which returns an object of type Product.
         4. ConcreteCreator - This is a class which implements the Creator class and overrides the factory method to return an instance of a ConcreteProduct.
         */

        #region 1. Product interface or abstract class
        /// <summary>
        /// 1. Product
        /// </summary>
        public interface IDrive
        {
            void Drive();
        }

        public class Air : IDrive
        {
            public void Drive()
            {
               // throw new NotImplementedException();
            }
        }
        #endregion

        #region 2. ConcreteProduct like Car, Bus etc which implement common product behavior 
        /// <summary>
        /// 2. ConcreteProduct
        /// </summary>
        public class Bus : IDrive
        {
            
            public void Drive()
            {
                
                Console.WriteLine("Bus can drive {0} km", 20);
            }
        }

        public class Car : IDrive
        {
            public void Drive()
            {
                Console.WriteLine("Car can drive {0} km", 50);
            }
        }

        public class Scooter : IDrive
        {
            public void Drive()
            {
                Console.WriteLine("Scooter can drive {0} km", 100);
            }
        }
        #endregion

        #region 3. Creator -> interface or abstract class for concreate class interface whihc are implemented by Product 
        public interface IVehicleFactory
        {
            IDrive GetVehicleKm(VehicleType vehicleType);
        }
        //consider this will be supplied dynamically based on clients
        public enum VehicleType
        {
            Car,
            Bus,
            Scooter,
            Air
        }

        #endregion

        #region 4. ConcreteCreator , implement creator
        public class ConcreteVehicleFactory : IVehicleFactory
        {
            public IDrive GetVehicleKm(VehicleType vehicleType)
            {
                switch (vehicleType)
                {
                    case VehicleType.Scooter:
                        return new Scooter();
                    case VehicleType.Bus:
                        return new Bus();
                    case VehicleType.Car:
                        return new Car();
                    default:
                        throw new ApplicationException(string.Format("Vehicle cannot be created"));
                }

            }
        }
        #endregion

       //Client Code
        static void Main_11(string[] args)
        {
            ConcreteVehicleFactory factoryMethod = new ConcreteVehicleFactory();
            IDrive vehicle = factoryMethod.GetVehicleKm(VehicleType.Car);
            vehicle.Drive();
        }
    }
#endregion
}
