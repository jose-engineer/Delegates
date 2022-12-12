using System;

namespace ActionAndFunc {
    internal class Program {
        static void Main(string[] args) {
            Utility.PassMeWork(WriteHello); //we pass a function that does not return a value - Action)
            Utility.PassMeWork(WriteBye);
            Console.WriteLine();
            Utility.PassMeLogic(CalculateLength); //we pass a function that does return a value - Func<string, int>
            Utility.PassMeLogic(CalculateVocals);
        }

        public static void WriteHello(string input) {
            Console.WriteLine($"Hello {input}");
        }
        public static void WriteBye(string input) {
            Console.WriteLine($"Bye {input}");
        }

        public static int CalculateLength(string input) {
            return input.Length;
        }
        public static int CalculateVocals(string input) {
            return 3; //logic to calculate vocals goes here
        }
    }

    public static class Utility {

        //public delegate void Delegado(string input); //we don't need this anymore        

        public static void PassMeWork(Action<string> work) { //using Action reduce the need to create our own delegates
            work("Jesus");
        }

        public static void PassMeLogic(Func<string, int> worker) { //receives a string and returns an int
            int count = worker("Metronomy");//Some function passed here is going to calculate a count based on that string 
            //we don't know what the logic is, could be counting only the vocals, or counting how many times "0" occurs, etc
            Console.WriteLine($"Function returned: {count}");
        }
        
    }
}
