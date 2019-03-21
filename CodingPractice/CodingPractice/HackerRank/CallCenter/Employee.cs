using System;
using System.Collections.Generic;
using System.Text;

namespace CodingPractice.HackerRank.CallCenter
{
    /*
Imagine you have a call center with three levels of employees: respondent, manager, and director. 
An incoming telephone call must be first allocated to a respondent who is free. If the respondent 
can't handle the call, he or she must escalate the call to a manager. If the manager is not free or 
notable to handle it, then the call should be escalated to a director. Design the classes and data 
structures for this problem. Implement a method dispatchCaL L() which assigns a call to the first 
available employee.
*/
    
    public abstract class Employee
    {
        public string name;
        public int id;
        public Rank rank;
        public bool available;

        public Employee(int id, string name, Rank rank)
        {
            this.name = name;
            this.id = id;
            this.rank = rank;
            this.available = true;
        }

        public abstract void getCall();

        public bool isAvailable()
        {
            return available;
        }


    }

    public class Responder : Employee
    {
        public Responder(int id, string name, Rank rank) : base(id, name, rank)
        {

        }

        public override void getCall()
        {
            available = false;
            Console.WriteLine("Respondent No." + id + " " + name + " is answering the phone");
        }
    }

    public class Manager : Employee
    {
        public Manager(int id, string name, Rank rank) : base(id, name, rank)
        {

        }

        public override void getCall()
        {
            available = false;
            Console.WriteLine("Respondent No." + id + " " + name + " is answering the phone");
        }
    }


    public class Director : Employee
    {
        public Director(int id, string name, Rank rank) : base(id, name, rank)
        {

        }

        public override void getCall()
        {
            available = false;
            Console.WriteLine("Respondent No." + id + " " + name + " is answering the phone");
        }
    }

    public class CallHandler
    {
        List<Responder> responders = new List<Responder>();
        List<Manager> managers = new List<Manager>();
        List<Director> directors = new List<Director>();
        Responder responder;
        Manager manager;
        Director director;
        public void generateEmployee()
        {
            for (int i = 0; i < 10; i++)
            {
                responder = new Responder(i, "Responder " + i, Rank.Responder);
                responders.Add(responder);
            }

            for (int i = 0; i < 4; i++)
            {
                manager = new Manager(i * 10, "Manager " + i * 10, Rank.Responder);
                managers.Add(manager);
            }

            for (int i = 0; i < 2; i++)
            {
                director = new Director(i * 100, "Director " + i * 100, Rank.Responder);
                directors.Add(director);
            }
        }

        public void dispatchCall()
        {
            foreach (Responder res in responders)
            {
                if (res.isAvailable())
                {
                    res.getCall();
                    return;
                }
            }

            foreach (Manager res in managers)
            {
                if (res.isAvailable())
                {
                    res.getCall();
                    return;
                }
            }

            foreach (Director res in directors)
            {
                if (res.isAvailable())
                {
                    res.getCall();
                    return;
                }
            }
        }

    }


    public enum Rank
    {
        Director = 1,
        Manager = 2,
        Responder = 3

    }
}
