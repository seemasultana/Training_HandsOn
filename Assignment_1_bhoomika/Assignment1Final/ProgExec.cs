using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1Final
{
    class Program
    {
        static void Main(string[] args)
        {
            TechEmployees t = new TechEmployees();
            t.Passwordd = "BYadwad";
            //t.EmpDisplay();
            //t.TechEmpDisplay();

            Manager m = new Manager();
            //m.ManagerDisplay();

            Console.WriteLine("Enter the Employee ID (EmpId) to display the details: ");
            int Id = Convert.ToInt32(Console.ReadLine());
            if (Id == t.EmpId)
            {
                t.EmpDisplay();
                t.TechEmpDisplay();
                m.ManagerDisplay();

            }
            else
            {
                Console.WriteLine("Employee ID entered is INCORRECT");
            }

        }
    }
}
