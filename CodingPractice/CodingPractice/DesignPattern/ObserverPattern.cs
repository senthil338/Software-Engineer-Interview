using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.DesignPattern
{
    /*
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
            • Subject, which is used to register observers. Objects use this interface to register as observers and also to remove themselves
            from being observers.
            • Observer, defines an updating interface for objects that should be notified of changes in a subject. All observers need to
            implement the Observer interface. This interface has a method update(), which gets called when the Subject’s state changes.
            • ConcreteSubject, stores the state of interest to ConcreteObserver objects. It sends a notification to its observers when its state
            changes. A concrete subject always implements the Subject interface. The notifyObservers() method is used to update
            all the current observers whenever the state changes.
            • ConcreateObserver, maintains a reference to a ConcreteSubject object and implements the Observer interface. Each observer
            registers with a concrete subject to receive updates.
    */
    public class ObserverPattern
    {
        public static void Main(String[] args)
        {
            Subject subject = new CommentaryObject(new List<Observer>(), "Cricket  - Match[June 14 2019]");
            Observer observer = new SMSUsers(subject, "Gokul [Chennai]");
            observer.subscribe();
            Console.WriteLine();
            Observer observer2 = new SMSUsers(subject, "Rajiv [London]");
            observer2.subscribe();
            Commentary cObject = ((Commentary)subject);
            cObject.setDesc("Welcome to live Cricket match");
            cObject.setDesc("Current score 0-0");
            Console.WriteLine();
            observer2.unSubscribe();
            Console.WriteLine();
            cObject.setDesc("It’s a six!!");
            cObject.setDesc("Current score 6-0");
            Console.WriteLine();
            Observer observer3 = new SMSUsers(subject, "Ragwendra [Paris]");
            observer3.subscribe();
            Console.WriteLine();
            cObject.setDesc("It’s another six!!");
            cObject.setDesc("25th over score 120-2");
            //Console.ReadLine();


            subject = new CommentaryObject(new List<Observer>(), "Cricket  - Match[June 15 2019]");
            observer = new SMSUsers(subject, "Gokul [Chennai]");
            observer.subscribe();
            Console.WriteLine();
            cObject = ((Commentary)subject);
            cObject.setDesc("It’s a four!!");
            cObject.setDesc("Current score 4-0");

            Console.ReadLine();
        }
        public interface Subject
        {
             void subscribeObserver(Observer observer);
             void unSubscribeObserver(Observer observer);
             void notifyObservers();
             String subjectDetails();
        }

        public interface Observer
        {
             void update(String desc);
             void subscribe();
             void unSubscribe();
        }

        public interface Commentary
        {
            void setDesc(String desc);
        }

        public class CommentaryObject : Subject, Commentary
        {
            private List<Observer> observers;
            private String desc;
            private String _subjectDetails;
            public CommentaryObject(List<Observer> observers, String subjectDetails)
            {
                this.observers = observers;
                this._subjectDetails = subjectDetails;
            }

            public void subscribeObserver(Observer observer)
            {
                observers.Add(observer);
            }

            public void unSubscribeObserver(Observer observer)
            {
                // int index = observers.IndexOf(observer);
                observers.Remove(observer);
            }

            public void notifyObservers()
            {
                Console.WriteLine();
                foreach (Observer observer in observers)
                {
                    observer.update(desc);
                }
            }

            public void setDesc(String desc)
            {
                this.desc = desc;
                notifyObservers();
            }

            public String subjectDetails()
            {
                return _subjectDetails;
            }
        }

        public class SMSUsers : Observer
        {
            private Subject subject;
            private String desc;
            private String userInfo;
            public SMSUsers(Subject subject, String userInfo)
            {
                if (subject == null)
                {
                    throw new ArgumentException("No Publisher found.");
                }
                this.subject = subject;
                this.userInfo = userInfo;
            }

            public void update(String desc)
            {
                this.desc = desc;
                display();
            }
            private void display()
            {
                Console.WriteLine("[" + userInfo + "]: " + desc);
            }

            public void subscribe()
            {
                Console.WriteLine("Subscribing " + userInfo + " to " + subject.subjectDetails() + " ...");
                this.subject.subscribeObserver(this);
                Console.WriteLine("Subscribed successfully.");
            }

            public void unSubscribe()
            {
                Console.WriteLine("Unsubscribing " + userInfo + " to " + subject.subjectDetails() + " ...");
                this.subject.unSubscribeObserver(this);
                Console.WriteLine("Unsubscribed successfully.");
            }
        }


}
}
