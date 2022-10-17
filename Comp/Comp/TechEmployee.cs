using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace handson1
{
    public class TechEmployee : Employee
    {
         string Designation;
         string ReportingTo;
         int TotalExp;
        public TechEmployee()
        {
            Console.WriteLine("This is a constructor for TechEmployee Class");
        }
        public TechEmployee(string name, string gender, string dateOfBirth, string email, string password, int employeeId, string designation, string reportingTo, int totalExp)
        {
            this.Name = name;
            this.Gender = gender;
            this.DateOfBirth = dateOfBirth;
            this.Email = email;
            this.Password = password;
            this.EmployeeId = employeeId;
            this.Designation = designation;
            this.ReportingTo = reportingTo;
            this.TotalExp = totalExp;
        }
        public void InsertTechemployees()
        {
            InsertTechemployees();
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
            DisplayTechEmployee();
            Console.WriteLine("Designation:" + Designation);
            Console.WriteLine("ReportingTo:" + ReportingTo);
            Console.WriteLine("Total Experience:" + TotalExp);
        }

    }
}