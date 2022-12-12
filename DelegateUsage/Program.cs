using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateUsage
{
    delegate bool IsPromotableDelegado(Empleado emp);

    class Program
    {
        static void Main(string[] args)
        {
            List<Empleado> lst = new List<Empleado>();
            lst.Add(new Empleado { Id = 1, Name = "Hernan", Salary = 35000, Experience = 6 });
            lst.Add(new Empleado { Id = 2, Name = "Cucho", Salary = 6000, Experience = 4 });
            lst.Add(new Empleado { Id = 3, Name = "Cañas", Salary = 7000, Experience = 7 });
            lst.Add(new Empleado { Id = 4, Name = "Toño", Salary = 3000, Experience = 3 });

            IsPromotableDelegado del = new IsPromotableDelegado(IsPromotable);
            Empleado.PromoteEmployee(lst, del);

            //Empleado.PromoteEmployee(lst, emp => emp.Experience > 5);

            Console.ReadKey();
        }

        public static bool IsPromotable(Empleado empleado)
        {
            if (empleado.Experience > 5)
                return true;
            else
                return false;
        }
    }    

    class Empleado
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
        public int Experience { get; set; }

        public static void PromoteEmployee(List<Empleado> lstEmp, IsPromotableDelegado delegado) //you don't have any logic inside the function, thta's why is loosly coupled
        {
            foreach (var item in lstEmp)
            {
                if (delegado(item))
                {
                    Console.WriteLine("{0} ha sido promovido.", item.Name);
                }
            }
        }

    }
}
