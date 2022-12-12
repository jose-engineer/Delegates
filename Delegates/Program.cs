using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Type safe function pointer, it holds a pointer to the function
namespace Delegates
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>();

            employees.Add(new Employee() { ID = 1, Name = "Emelia", Salary = 5000, Experience = 5 });
            employees.Add(new Employee { ID = 2, Name = "Cucho", Salary = 6000, Experience = 6 });
            employees.Add(new Employee { ID = 3, Name = "Cañas", Salary = 7000, Experience = 7 });
            employees.Add(new Employee { ID = 4, Name = "Toño", Salary = 3000, Experience = 3 }); 

            Employee.Promotion(employees);

            Console.ReadKey();

        }
    }

    public class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
        public int Experience { get; set; }

        public static void Promotion(List<Employee> employees)
        {            
            foreach (var item in employees)
            {
                if (item.Experience > 5)
                {
                    Console.WriteLine("Empleado {0} promovido.", item.Name);
                }
            }            
        }

    }
}
