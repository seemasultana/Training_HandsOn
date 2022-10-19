using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeConsoleApp
{
    public class TechEmployees : Employee
    {
        public string Designation;
        public string ReportingTo;
        public double TotalExp;


        public TechEmployees()
        {
            
        }

        public TechEmployees(string name, string gender, string dateOfBirth, int age, string email, string password, int empId, string designation, string reportingTo, double totalExp)
        {
            Name = name;
            Gender = gen;
            DateOfBirth = dob;
            Age = age;
            Email = email;
            Password = password;
            EmpId = empId;
            Designation = designation;
            ReportingTo = reportingTo;
            TotalExp = totalExp;
        }

        public void TechEmpDisplay()
        {
            Console.WriteLine("\n Technical Employee details are: ");
            Console.WriteLine("Designation: " + Designation);
            Console.WriteLine("ReportingTo: " + ReportingTo);
            Console.WriteLine("TotalExperince " + TotalExp);

        }
    }
}
