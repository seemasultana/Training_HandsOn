using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalAssig1
{
    public class TechEmployees : Employee
    {
        public string Designation;
        public string ReportingTo;
        public double TotalExp;

        public TechEmployees()
        {
            Console.WriteLine("\nDefault Constructor");
        }

        public TechEmployees(string name, string gender, string dateOfBirth, int age, string email, string password, int empId, string designation, string reportingTo, double totalExp)
        {
            Name = name;
            Gender = gender;
            DateOfBirth = dateOfBirth;
            Age = age;
            Email = email;
            Password = password;
            EmpId = empId;
            Designation = designation;
            ReportingTo = reportingTo;
            TotalExp = totalExp;
            Console.WriteLine("Parameterized constructor");
        }

        public void TechEmpDisplay()
        {
            EmpDisplay();
            Console.WriteLine("\nTech Employee details are displayed below: ");
            Console.WriteLine("Designation: " + Designation);
            Console.WriteLine("Reporting To: " + ReportingTo);
            Console.WriteLine("Total Experience in years: " + TotalExp);
        }
    }
}
