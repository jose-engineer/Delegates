using System;

namespace UnderstandingEvents {
    internal class Program {
        static void Main(string[] args) {
            Utility.Evento += WriteHello; //Adding a function to an event
            Utility.Evento += WriteBye;

            Utility.DoSomething();
        }

        public static void WriteHello(string input) {
            Console.WriteLine($"Hello {input}");
            Utility.Evento -= WriteHello; //clean up handler
        }
        public static void WriteBye(string input) {
            Console.WriteLine($"Bye {input}");
            Utility.Evento -= WriteBye; //clean up handler
        }
    }

    public static class Utility {

        public delegate void Delegado(string input);
        public static event Delegado Evento; //When Evento gets raised it will invoke Delegado

        public static void PassMeWork(Delegado work) { //Delegate some work back to the caller, so call back to the caller and apply some logic, in this case add "Hello" string
            work("Jesus");
        }

        public static void DoSomething() {

            Console.WriteLine("I'm about to do something");

            if (Evento != null) {
                Evento("I did something"); //raise the event
            }
        }
    }
}
