using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasicToAdvanced._20ExtraConcept.Events
{
    using System;

    class Alarm
    {
        public event Action AlarmRang;

        public void Ring()
        {
            Console.WriteLine("Alarm Ringing");

            AlarmRang?.Invoke();
        }
    }

    class MultipleEvents
    {
        static void WakeUp()
        {
            Console.WriteLine("Wake Up");
        }

        static void TurnOffAC()
        {
            Console.WriteLine("AC Turned Off");
        }

        static void MakeTea()
        {
            Console.WriteLine("Tea is Being Prepared");
        }

        static void Main()
        {
            Alarm alarm = new Alarm();

            alarm.AlarmRang += WakeUp;
            alarm.AlarmRang += TurnOffAC;
            alarm.AlarmRang += MakeTea;

            //if we dont want to call MakeTea method when alarm rang we can unsubscribe it from the event.
            //it will remove the method from the invocation list of the event and it will not be called when the event is raised.
            alarm.AlarmRang -= MakeTea;

            alarm.Ring();
        }
    }
}
