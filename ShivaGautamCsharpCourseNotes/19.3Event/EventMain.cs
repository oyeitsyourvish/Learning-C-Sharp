using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasicToAdvanced._19._3Event
{
    internal class EventMain
    {
        /* Event in C# :- used to notify when something happens.

        Example in real life:
            When you click a button → Click event fires
            So, event = notification system. 

         NOTE :- Events are based on delegates (a type that references methods) and
                 follow the publisher-subscriber pattern.
        @ Why use events?
            - Decoupling: Publishers and subscribers are loosely coupled.
            - Reusability: Multiple subscribers can listen to the same event.
            - Flexibility: Subscribers can choose which events to handle.

        when to use events?
            - User interface interactions (button clicks, mouse movements)
            - Data changes (property changes, collection updates)
            - System notifications (timers, file system changes)
        
         */

        public static void Main(string[] args)
        {
            EAlarm alarm = new EAlarm(); // Create an instance of the EAlarm class
            Person person = new Person(); // Create an instance of the Person class

            // Subscribe the person's WakeUp method to the alarm's AlarmRang event
            alarm.AlarmRang += person.WakeUp;

            alarm.RingAlarm(); // Trigger the alarm, which will call the person's WakeUp method

        }
    }
}
