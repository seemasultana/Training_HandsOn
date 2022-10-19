using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TejasiAsssignment1
{

   
    public class Program
    {
        static void Main(string[] args)
        {


            Employee emp = new Employee("Abhi", "Male", "14-Nov-2000", "abhiporwal@gmail.com", "dgrt5", 21, 12345);
            //emp.Empinfo();
            TechEmployee techemp = new TechEmployee("Software Engineer", "Manager", 13, "Vishal", "Male", "12-nov-2001", "vishal@gmail.com", "ERFEE5", 23, 12456);
            //techemp.TechEmpinfo();
            
            Manager manager = new Manager("Information Technology", "Manager", 4, 20, "tejasi", "Female", "14-Nov-2000", "tejasi@gmal.com", "hjjjj", 35, 6789);
            //manager.Managerinfo();
            
            
            
            Console.WriteLine("Enter Employee Id: ");
            int EmpId = Convert.ToInt32(Console.ReadLine());
            if (EmpId == emp.empId)
            {
                emp.Empinfo();

                
                
            }
            else if(EmpId  == techemp.empId)
            {
                techemp.TechEmpinfo();
            }
            else if(EmpId ==  manager.empId)
            {
                manager.Managerinfo();
            }
            else
            {
                Console.WriteLine("Employee Id is wrong");
            }
            Console.ReadKey();
        }
    }
}
