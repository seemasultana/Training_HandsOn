using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees
{
    public class TechEmployee:Employee
    {
        public string Designation;
        public string ReportingTo;
        public int TotalExp;
        public TechEmployee()
        {
            Console.WriteLine("This is a constructor for TechEmployee Class");
        }
        public TechEmployee(string name, string gender, string dateOfBirth, int age, string email, string password, int employeeId, string designation, string reportingTo, int totalExp)
        {
            this.Name = name;
            this.Gender = gender;
            this.DateOfBirth = dateOfBirth;
            this.Age = age;
            this.Email = email;
            this.Password = password;
            this.EmployeeId = employeeId;
            this.Designation = designation;
            this.ReportingTo = reportingTo;
            this.TotalExp = totalExp;
        }
        public void InsertTechEmployee()
        {
            InsertEmployee();
            Console.WriteLine("Enter The Designation: ");
            Designation = Console.ReadLine();
            Console.WriteLine("Enter The ReportingTo: ");
            ReportingTo = Console.ReadLine();
            Console.WriteLine("Enter The TotalExp: ");
            TotalExp = Convert.ToInt32(Console.ReadLine());
           
        }
        public void DisplayTechEmployee()
        {
            
            Console.WriteLine("Details Of Tech Employee:");
            DisplayEmployee();
            Console.WriteLine("Designation:"+ Designation);
            Console.WriteLine("ReportingTo:"+ ReportingTo);
            Console.WriteLine("Total Experience:"+ TotalExp);
        }  
      
    }
}
