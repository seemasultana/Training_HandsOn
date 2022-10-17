using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeeDetails
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Employee_Id:");
            Employee E1 = new Employee();
            E1.PrintEmployee();
            E1.EmpId = Convert.ToInt32(Console.ReadLine());
            TechEmployee E2 = new TechEmployee();
            E2.PrintTechEmployee();
            Manager E3 = new Manager();
            E3.PrintManager();
            Console.ReadKey();
        }
    }
}
