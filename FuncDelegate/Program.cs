using System;
using System.Collections.Generic;
using System.Linq;

namespace FuncDelegate {
    internal class Program {
        static void Main(string[] args) {

            List<Employee> lst = new List<Employee>()
            {
                new Employee { Id = 001, Name = "Mark"},
                new Employee { Id = 002, Name = "Henry"},
                new Employee { Id = 003, Name = "Albert"}
            };

            Func<Employee, string> funcDel1 = emp => "Name: " + emp.Name; //Pass an Employee object and returns a string
            IEnumerable<string> names = lst.Select(funcDel1); //Select expects a Func}

            //IEnumerable<string> names = lst.Select(emp => "Name" + emp.Name); //Func and lamba expressions are the same

            foreach (string name in names)
                Console.WriteLine(name);



            //Func delegate example with multiple parameters

            Func<int, int, string> funcDel2 = (num1, num2) => "The sum is: " + (num1 + num2).ToString();
            string result = funcDel2(3, 5);
            Console.WriteLine(result);

        }

        public class Employee {
            public int Id { get; set; }
            public string Name { get; set; }    
        }
    }
}
