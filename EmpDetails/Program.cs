using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace EmpDetails
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee E1 = new Employee(99020111,"Pranaya", "Male", "14-09-2001", 21, "Pranaya@gmail.com", "pranaya@123");
            TechEmployee E2 = new TechEmployee(99020149,"Rajasutha","Female","18-09-2000",22,"raji@harman.com","raji@123","Associate Engineer","zulquar",6);
            Manager E3 = new Manager( 99020161,"zulquar", "male", "13-04-1987", 35, "zulquar@harman.com", "zulquar@123", "Engineering", "Manager", 4, 12);
            Console.WriteLine("Enter the Employee_Id:");
       
            int EmpId = Convert.ToInt32(Console.ReadLine());
            if (EmpId == E1.EmpId)
            {
                E2.PrintEmployee();
            }
            else if (EmpId == E2.EmpId)
            {
                E2.PrintTechEmployee();
            }
            else if (EmpId == E3.EmpId)
            {
                E3.PrintManager();
            }
            else
            {
                Console.WriteLine("Enter valid Employee_id");

            }
            Console.ReadLine();
        }
    }
}


