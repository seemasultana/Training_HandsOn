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
        }
        public TechEmployee(string name, string gender, string dateOfBirth, string email,int age, int employeeId, string designation, string reportingTo, int totalExp)
        {
            Name = name;
            Gender = gender;
            DateOfBirth = dateOfBirth;
            Email = email;
            Age = age;
            EmployeeId = employeeId;
            Designation = designation;
            ReportingTo = reportingTo;
            TotalExp = totalExp;
        }
 
        public void DisplayTechEmployee()
        {
            
            Console.WriteLine("Details Of Tech Employee:");
            Console.WriteLine("Name:" + Name);
            Console.WriteLine("Gender:" + Gender);
            Console.WriteLine("DateOfBirth:" + DateOfBirth);
            Console.WriteLine("Email:" + Email);
            Console.WriteLine("Age:" + Age);
            Console.WriteLine("EmployeeId:" + EmployeeId);
            Console.WriteLine("Designation:" + Designation);
            Console.WriteLine("ReportingTo:" + ReportingTo);
            Console.WriteLine("Total Experience:" + TotalExp);
        }

    }
}