using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeAssignment
{
     class TechEmployees: Employee

    {
      

        public string Designation { get; set; }
        public string ReportingTo { get; set; }
        public int TotalExperience { get; set; }

        public TechEmployees()
        {

        }

        public TechEmployees(string name, string gender, string dateOfBirth, int age, string email, string password, int employeeId,string designation, string reportingTo, int totalExperience)
        {
            this.AcceptDetails(name, gender, dateOfBirth, age, email, password, employeeId);
            Designation = designation;
            ReportingTo = reportingTo;
            TotalExperience = totalExperience;
        }

        public void AcceptDetailsTechEmp(string name, string gender, string dateOfBirth, int age, string email, string password, int employeeId, string designation, string reportingTo, int totalExperience)
        {
            this.AcceptDetails(name, gender, dateOfBirth, age, email, password, employeeId);
            Designation = designation;
            ReportingTo = reportingTo;
            TotalExperience = totalExperience;
        }

        public void DisplayDetailTechEmp(int EmployeeId)
        {
            Console.WriteLine("Employee Details: ");
            this.DisplayDetails(EmployeeId);
            Console.WriteLine("Designation: "+this.Designation);
            Console.WriteLine("Reporting To: "+this.ReportingTo);
            Console.WriteLine("Total Experience: "+this.TotalExperience);
        }
    }
}
