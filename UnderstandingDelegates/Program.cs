using System;

namespace UnderstandingDelegates {    

    internal class Program {
        static void Main(string[] args) {
            Utility.PassMeWork(WriteHello); //flexibility to pass around functions like WriteHello
            Utility.PassMeWork(WriteBye);
            Utility.PassMeWork(WriteAfternoon);
        }

        public static void WriteHello(string input) {
            Console.WriteLine($"Hello {input}");
        }
        public static void WriteBye(string input) {
            Console.WriteLine($"Bye {input}");
        }
        public static void WriteAfternoon(string input) {
            Console.WriteLine($"Good afternoon {input}");
        }
    }

    public static class Utility {

        public delegate void Delegado(string input);        

        public static void PassMeWork(Delegado work) { //Delegate some work back to the caller, so call back to the caller and apply some logic, in this case add "Hello" string
            work("Jesus");
        }
    }
}
