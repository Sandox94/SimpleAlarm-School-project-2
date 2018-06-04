using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLCommunication
{
    public class Subscriber
    {

        public static event EventHandler SubscriberCreated;

        //Auto-implementerte properties
        public string Email { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Telephone { get; set; }
        
        //Constructor for the subscriber invokes the method OnSubscriberCreated, which raises an event
        public Subscriber(string email, string firstName, string lastName, int phoneNumber)
        {
            Email = email;
            FirstName = FormatName(firstName);
            LastName = FormatName(lastName);
            Telephone = phoneNumber;
            OnSubscriberCreated();
        }
        
        //Formats names with capital first letter
        private string FormatName(string name)
        {
            name = name.ToLower();
            return char.ToUpper(name[0]) + name.Substring(1);
        }

        //Method to raise the event SubscriberCreated
        protected virtual void OnSubscriberCreated()
        {
            if (SubscriberCreated != null)
            {
                SubscriberCreated(this, EventArgs.Empty);
            }
        }
        //See SQLCom definition for comments and implementation
        public void UpdateSubscriber(string newEmail, string newFirstName, string newLastName, int newPhoneNumber)
        {
            SQLCom.UpdateSubscriber(this, newEmail, newFirstName, newLastName, newPhoneNumber);
        }

        public void RemoveSubscriberFromSQL()
        {
            SQLCom.DeleteSubscriber(this);
        }

        public void SubscribeTo(AlarmtypesEnum alarmtype)
        {
            SQLCom.SubscribesTo(this, alarmtype);
        }

        public void UnsubscribeTo(AlarmtypesEnum alarmtype)
        {
            SQLCom.UnsubscribeTo(this, alarmtype);
        }

        public void ShowSubscribeList()
        {
            Console.WriteLine(this.FirstName + " " + this.LastName + " subscribes to the following alarms:");
            List<string> AlarmList = SQLCom.GetSubscriberAlarmList(this);
            foreach (string alarm in AlarmList)
            {
                Console.WriteLine(alarm);
            }
        }
    }
}
