using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace employeees
{
    public class TechEmployee : Employee
    {

        public string Designation;
        public string ReportingTo;
        public int TotalExp;
        public TechEmployee() //default constructor
        {

        }

        // Parameterized constructor
        public TechEmployee(string name, char gender, string dateOfBirth, int age,
                   string email, string password, int empId,
                   string designation, string reportingTo, int totalExp)
        {
            this.EmpAccept(name, gender, dateOfBirth, age, email, password, empId);
            this.Designation = designation;
            this.ReportingTo = reportingTo;
            this.TotalExp = totalExp;
        }
        public void TechEmpDisp()
        {
            Console.WriteLine("...Techemployee details...\n");
            EmpDisp();
            Console.WriteLine("Designation : " + this.Designation);
            Console.WriteLine("ReportingTo : " + this.ReportingTo);
            Console.WriteLine("TotalExp : " + this.TotalExp);
        }
    }

}
