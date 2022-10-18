using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees
{

    public class Mainclass
    {
        public static int Empid;
        static public void Main(string[] args)
        {
            /*  //Employee employee = new Employee("Rishabh Singh", "M", "23/10/2000", 23, "mr.23rishabh@gmail.com", "@Rishabh23", 101);
              Employee employee = new Employee();
              employee.InsertEmployee();
              employee.DisplayEmployee();*/

            TechEmployee tech = new TechEmployee("Rishabh Singh", "M", "23/10/2000", 23, "mr.23rishabh@gmail.com", "@Rishabh23", 101, "Software Devloper", "Zulquar Siddiquee", 2);
            //TechEmployee tech = new TechEmployee();
            //tech.InsertTechEmployee();
            //tech.DisplayTechEmployee();


            Manager manager = new Manager("Zulquar Siddique", "M", "23/10/2000", 30, "Zulquar@gmail.com", "@Rishabh23", 102, "HealthCare", "Manager", "Rishabh Singh, Arjun Lal", 10);
            //Manager manager = new Manager();
            //manager.InsertManager();
            //manager.DisplayManager();
            Console.WriteLine("***************************************************");
            Console.WriteLine("Enter EmployeeId to generate Emp Card:");
            Mainclass.Empid = Convert.ToInt32(Console.ReadLine());
            if (Mainclass.Empid == tech.EmployeeId)
            {
                tech.DisplayTechEmployee();
            }
            else if (Mainclass.Empid == manager.EmployeeId)
            {
                manager.DisplayManager();
            }


        }

    }
}
//Give 101 Empid to see tech employee details and 102 Empid to see manager employee details