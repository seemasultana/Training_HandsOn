using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace employeees
{
    // Manager class inheriting from Employee class
    public class Manager : Employee
    {

        public string Department;
        public string Title;
        public int Reportees;
        public int TotalExp;

        // Default constructor
        public Manager()
        {

        }

        // Parameterized constructor
       
        public Manager(string Name, char Gender, string DateOfBirth, int Age,
                string Email, string Password, string EmpId,
                string Department, string Title, int Reportees,
                int TotalExp)
        {
            //base class
            this.EmpAccept(Name, Gender, DateOfBirth, Age, Email, Password, EmpId);
            //inherited class
            this.Department = Department;
            this.Title = Title;
            this.Reportees = Reportees;
            this.TotalExp = TotalExp;
        }
        // Accept Mgr Details
        public void AcceptManager(string Name, char Gender, string DateOfBirth,
                int Age, string Email, string Password,
                string EmpId, string Department, string Title,
                int Reportees, int TotalExp)
        {
            // Base Class
            this.EmpAccept(Name, Gender, DateOfBirth, Age, Email, Password, EmpId);

            // Inherited class
            this.Department = Department;
            this.Title = Title;
            this.Reportees = Reportees;
            this.TotalExp = TotalExp;
        }


        // Display Mgr Details
        public void ManagerDisp(string EmpId)
        {
            // Base Class Function
            this.EmpDisp(EmpId);

            // Inherited class
            Console.WriteLine("Department : " + this.Department);
            Console.WriteLine("ReportingTo : " + this.Title);
            Console.WriteLine("Reportees : " + this.Reportees);
            Console.WriteLine("TotalExp : " + this.TotalExp);
        }
    }
}
