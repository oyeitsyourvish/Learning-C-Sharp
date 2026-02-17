using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasicToAdvanced._19._3Event
{
    internal class EAlarm
    {
        public delegate void AlarmHandler(); // Define a delegate type for the event
        public event AlarmHandler AlarmRang; // Declare an event of the delegate type

        public void RingAlarm()
        {
            Console.WriteLine("Alarm is ringing...");
            AlarmRang?.Invoke();  // Invoke the event (call all subscribed handlers)
        }

    }
}
