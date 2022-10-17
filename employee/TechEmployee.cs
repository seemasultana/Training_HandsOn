using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace employeees
{
    // TechEmployee class inheriting from Employee class
    public class TechEmployee : Employee
    {

        public string Designation;
        public string ReportingTo;
        public int TotalExp;

        // Default Constructor
        public TechEmployee()
        {
        }

        // Parameterized constructor
       
        public TechEmployee(string Name, char Gender, string DateOfBirth, int Age,
                   string Email, string Password, string EmpId,
                   string Designation, string ReportingTo, int TotalExp)
        {
            //base class
            this.EmpAccept(Name, Gender, DateOfBirth, Age, Email, Password, EmpId);
            this.Designation = Designation;
            this.ReportingTo = ReportingTo;
            this.TotalExp = TotalExp;
        }
        // Accept Employee Details
        public void AcceptTechEmployee(string Name, char Gender,
                    string DateOfBirth, int Age, string Email,
                    string Password, string EmpId,
                    string Designation, string ReportingTo,
                    int TotalExp)
        {
            // Base class Function
            this.EmpAccept(Name, Gender, DateOfBirth, Age, Email, Password, EmpId);

            // Inherited class
            this.Designation = Designation;
            this.ReportingTo = ReportingTo;
            this.TotalExp = TotalExp;
        }





        // Display Employee Details
        public void TechEmpDisp(string EmpId)
        {
            // Base class function
            this.EmpDisp(EmpId);

            // Inherited class
            Console.WriteLine("Designation : " + this.Designation);
            Console.WriteLine("ReportingTo : " + this.ReportingTo);
            Console.WriteLine("TotalExp : " + this.TotalExp);
        }
    }

}
