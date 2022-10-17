using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TejasiAssignment1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Employee Name: ");
            string name = Console.ReadLine();
            Console.Write("Enter Employee Gender: ");
            string empGender = Console.ReadLine();
            Console.Write("Enter Employee Date of Birth: ");
            string empDateOfBirth = Console.ReadLine();
            Console.Write("Enter Employee age:");
            int age = Convert.ToInt32(Console.ReadLine());


            Console.Write("Enter Employee EmailId : ");
            string empEmailId = Console.ReadLine();
            Console.Write("Enter Employee Password: ");
            string empPassword = Console.ReadLine();
            Console.Write("Enter Employee Id: ");
            int empId = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter TechEmployee Designation: ");
            string techEmployeeDesignation = Console.ReadLine();
            Console.Write("Enter TechEmployee Reporting To: ");
            string techEmployeeReportingTo = Console.ReadLine();
            Console.Write("Enter TechEmployee TotalExp: ");
            int techEmployeeTotalExp = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Manager Department: ");
            string Department = Console.ReadLine();
            Console.Write("Enter Title: ");
            string Title = Console.ReadLine();
            Console.Write("Enter Manager Reportees: ");
            int Reportees = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Manager TotalExperience: ");
            int TotalExperience = Convert.ToInt32(Console.ReadLine());









            Employee emp = new Employee();
            emp.Empinfo(name, empGender, empDateOfBirth, empEmailId, age, empPassword, empId);
            TechEmployee techemp = new TechEmployee();
            techemp.TechEmpinfo(techEmployeeDesignation, techEmployeeReportingTo, techEmployeeTotalExp);
            techemp.Empinfo(name, empGender, empDateOfBirth, empEmailId, age, empPassword, empId);

            Manager manager = new Manager();
            manager.Managerinfo(Department, Title, Reportees, TotalExperience);
            Console.WriteLine("Enter Employee Id: ");
            int EmpId = Convert.ToInt32(Console.ReadLine());
            if (EmpId == empId)
            {
                Console.WriteLine("Name of Employee is " + " " + name);
                Console.WriteLine("Gender of Employee is " + " " + empGender);
                Console.WriteLine("Date of Birth of Employee is " + " " + empDateOfBirth);
                Console.WriteLine("Email Id of Employee is " + " " + empEmailId);
                Console.WriteLine("Employee age is " + " " + age);
                Console.WriteLine("Employee Password is:  " + " " + empPassword);
            }
            else 
            {
                Console.WriteLine("Empid is invalid");
            }
            Console.ReadKey();
        }

    }       
    
}
