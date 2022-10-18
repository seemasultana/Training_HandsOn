using EmployeeAssignment;
using System;

namespace Employee
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TechEmployees employees = new TechEmployees();
            employees.AcceptDetailsTechEmp("Shreya", "Female", "02/01/2001", 21, "shreya@gmail.com", "Shreya@123", 101, "Associate Engineer", "Zulquar", 1);
           // employees.DisplayDetailTechEmp(101);

            Manager manager = new Manager();
            manager.AcceptDetailsManager("Zulquar Siddhique", "Male", "8/02/1995", 28, "zulquar@gmail.com", "Zulquar@123", 201, "Manager", "HR", "Shreya", 8);
           // manager.DisplayManagerDetails(201);

            int choice=Convert.ToInt32(Console.ReadLine());
            if(choice==employees.EmployeeId)
            {
                employees.DisplayDetailTechEmp(101);
            }
            else if(choice==manager.EmployeeId)
            {
                manager.DisplayManagerDetails(201);
            }
            else
            {
                Console.WriteLine("Employee does not exists, Try Again!!");
            } 

        }
    }
}
