using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice1
{

    class TechEmployees : Employee
    {


        public string Designation;
        public string ReportingTo;
        public int TotalExp;



        public TechEmployees()
        {
            Console.WriteLine("Default constructor is called here");
        }

        public TechEmployees(string name, string gender, string dateOfBirth, int age, string emailID, int empID, string password, string designation, string reportingTo, int totalExp)
        {
            Name = name;
            Gender = gender;
            DateOfBirth = dateOfBirth;
            Age = age;
            EmailID = emailID;
            EmpID = empID;
            Password = password;
            Designation = designation;
            ReportingTo = reportingTo;
            TotalExp = totalExp;
            Console.WriteLine("Parameterized constructor is called here");
        }

        public void TechDisplay()
        {
            Console.WriteLine("  Tech Employee Details     ");
            Console.WriteLine("  ~~~~~~~~~~~~~~~~~~~~~     ");
            Display();
            Console.WriteLine("Designation=" + Designation);
            Console.WriteLine("Reporting To=" + ReportingTo);
            Console.WriteLine("Total Emperience=" + TotalExp);
        }
    }
}
