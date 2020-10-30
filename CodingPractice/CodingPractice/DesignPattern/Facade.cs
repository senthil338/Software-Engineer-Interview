using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.DesignPattern.FacadePattern
{
    /*
            The problem faced by the clients in using the Schedule Server is the complexity brought by the server in order to start and stop
     its services. The client wants a simple way to do it. The following is the code that clients required to write to start and stop the
    server. 
                 ScheduleServer scheduleServer = new ScheduleServer();
    To start the server, the client needs to create an object of the ScheduleServer class and then need to call the below methods in the
sequence to start and initialize the server.
                    scheduleServer.startBooting();
                    scheduleServer.readSystemConfigFile();
                    scheduleServer.init();
                    scheduleServer.initializeContext();
                    scheduleServer.initializeListeners();
                    scheduleServer.createSystemObjects();
                    System.out.println("Start working......");
                    System.out.println("After work done.........");

    To stop the server, the client needs to call the following methods in the same sequence.
                    scheduleServer.releaseProcesses();
                    scheduleServer.destory();
                    scheduleServer.destroySystemObjects();
                    scheduleServer.destoryListeners();
                    scheduleServer.destoryContext();
                    scheduleServer.shutdown();

        This looks a burden to them, they are not interested in doing all these stuffs, and why would they? Even though this might look
interesting to some of the clients who might be interested in the low-level interface of the system, most of them disliked it.
To resolve this, we will create a facade class which will wrap a server object. This class will provide simple interfaces (methods)
for the client. These interfaces internally will call the methods on the server object. Let us first see the code and then will discuss
more about it.
    */
    public class FacadeClientTest
    {
        public static void Main_1(string[] args)
        {
            ///Bofre facade implementation
            //ScheduleServer scheduleServer = new ScheduleServer();
            //scheduleServer.startBooting();
            //scheduleServer.readSystemConfigFile();
            //scheduleServer.init();
            //scheduleServer.initializeContext();
            //scheduleServer.initializeListeners();
            //scheduleServer.createSystemObjects();
            //Console.WriteLine("Start working......");
            //Console.WriteLine("After work done.........");

            //////To stop the server, the client needs to call the following methods in the same sequence.
            //scheduleServer.releaseProcesses();
            //scheduleServer.destory();
            //scheduleServer.destroySystemObjects();
            //scheduleServer.destoryListeners();
            //scheduleServer.destoryContext();
            //scheduleServer.shutdown();

            ////After Facade Implementation 
            ScheduleServer scheduleServer = new ScheduleServer();
            ScheduleServerFacade facadeServer = new ScheduleServerFacade(scheduleServer);
            facadeServer.startServer();
            Console.WriteLine("Start working......");
            Console.WriteLine("After work done.........");
            facadeServer.stopServer();
            /*
             Please note that, although the facade class has provided a simple interface to the complex subsystem, it has not encapsulated
            the subsystem. A client can still access the low-level interfaces of the subsystem. So, a facade provides an extra layer, a simple
            interface to the complex subsystem, but it does not completely hide the direct accessibility to the low-level interfaces of the
            complex subsystem.
             */
        }
    }
    public class ScheduleServerFacade
    {
        private ScheduleServer scheduleServer;
        public ScheduleServerFacade(ScheduleServer scheduleServer)
        {
            this.scheduleServer = scheduleServer;
        }
        public void startServer()
        {
            scheduleServer.startBooting();
            scheduleServer.readSystemConfigFile();
            scheduleServer.init();
            scheduleServer.initializeContext();
            scheduleServer.initializeListeners();
            scheduleServer.createSystemObjects();
        }
        public void stopServer()
        {
            scheduleServer.releaseProcesses();
            scheduleServer.destory();
            scheduleServer.destroySystemObjects();
            scheduleServer.destoryListeners();
            scheduleServer.destoryContext();
            scheduleServer.shutdown();
        }
    }
    public class ScheduleServer
    {
        public void startBooting()
        {
            Console.WriteLine("Start Booting");
        }
        public void readSystemConfigFile()
        {
            Console.WriteLine("Read System Config File");
        }
        public void init()
        {
            Console.WriteLine("Initialize");
        }
        public void initializeContext()
        {
            Console.WriteLine("Initialize Context");
        }
        public void initializeListeners()
        {
            Console.WriteLine("Initialize Listeners");
        }
        public void createSystemObjects()
        {
            Console.WriteLine("Create System Objects");
        }

        public void releaseProcesses()
        {
            Console.WriteLine("Release Processes");
        }
        public void destory()
        {
            Console.WriteLine("Destory");
        }
        public void destroySystemObjects()
        {
            Console.WriteLine("Destroy System Objects");
        }
        public void destoryListeners()
        {
            Console.WriteLine("Destory Listeners");
        }
        public void destoryContext()
        {
            Console.WriteLine("Destory Context");
        }
        public void shutdown()
        {
            Console.WriteLine("Shutdown");
        }
    }
  
}
