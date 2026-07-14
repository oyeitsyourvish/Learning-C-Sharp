using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasicToAdvanced._20ExtraConcept.Events
{
    public class Button
    {
        //Step1 ::-> This creates an event named Click.
        public event Action Click;
        public void Press()
        {
            Console.WriteLine("Button Pressed");

            //Step3 ::-> Raise the Event :- Notify everyone who subscribed.
            Click?.Invoke();
        }
    }
    public class EventExample
    {
        static void ShowMessage()
        {
            Console.WriteLine("Button clicked Messege Recieved");
        }
        static void Main(string[] args)
        {
            Button btn = new Button();

            //Step2 ::-> Subscribe to the Event :- When the event occurs, call ShowMessage().
            btn.Click += ShowMessage;
            btn.Press();

        }
    }



}


