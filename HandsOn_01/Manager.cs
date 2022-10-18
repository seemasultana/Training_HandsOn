using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeAssignment
{
     class Manager: Employee
    {
        public string Department { get; set; }
        public string Title { get; set; }
        public string Reportees { get; set; }
        public int TotalExp { get; set; }
     
        public Manager()
        {

        }

        public Manager(string name, string gender, string dateOfBirth, int age, string email, string password, int employeeId,string department, string title, string reportees, int totalExp)
        {
            this.AcceptDetails(name, gender, dateOfBirth, age, email, password, employeeId);
            Department = department;
            Title = title;
            Reportees = reportees;
            TotalExp = totalExp;
        }

        public void AcceptDetailsManager(string name, string gender, string dateOfBirth, int age, string email, string password, int employeeId, string department, string title, string reportees, int totalExp)
        {
            this.AcceptDetails(name, gender, dateOfBirth, age, email, password, employeeId);
            Department = department;
            Title = title;
            Reportees = reportees;
            TotalExp = totalExp;
        }

        public void DisplayManagerDetails(int EmployeeId)
        {
            Console.WriteLine();
            Console.WriteLine("Manager Details: ");
            this.DisplayDetails(EmployeeId);
            Console.WriteLine("Department: "+ this.Department);
            Console.WriteLine("Title: "+this.Title);
            Console.WriteLine("Reportees: "+this.Reportees);
            Console.WriteLine("Total Exoerience od Manager: "+this.TotalExp);
        }
    }
}
