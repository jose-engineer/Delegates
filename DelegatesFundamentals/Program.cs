using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesFundamentals
{
    public delegate void DelegadoImprime(string msg);

    class Program
    {
        static void Main(string[] args)
        {
            DelegadoImprime del = new DelegadoImprime(Imprime);
            del("Hola Susana");

            Console.ReadKey();
        }        

        public static void Imprime(string message)
        {
            Console.WriteLine(message);
        }
    }
}
