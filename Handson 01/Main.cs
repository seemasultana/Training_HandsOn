
using Company1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace company1
{
    class Program1
    {
        static void Main(string[] args)
        {
         
          TechEmployee techEmployee = new TechEmployee("Priyanka Gunda", "Female", "29-09-2000", "22", "Priyanka.Gunda@harman.com", "Swjb23n", 99020148, "Associate Engineer", "Zulquar", "6 months");
          techEmployee.TechDisplayEmployee();
          Manager manager = new Manager("Zulquar Siddique", "Male", "12-08-1980", "42", "Zulquar.Siddique@harman.com", "Swjb23n", 99011795,"Engineering","Associate Director","50","15 years");
          manager.ManagerDisplayEmployee();
          Console.WriteLine(" Please enter employee id:");
          int  Empid = Convert.ToInt32(Console.ReadLine());
            if(Empid == techEmployee.empid)
            {
                techEmployee.TechDisplayEmployee();
            }
            else if(Empid == manager.empid)
            {
                manager.ManagerDisplayEmployee();
            }
            else
            {
                Console.WriteLine("please enter valid employee id");
            }
          
        }
    }
}

