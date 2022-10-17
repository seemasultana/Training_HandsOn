using Assig1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1Final
{
    public class TechEmployees : Employee
    {
        public string Designation = "Associate Engineer : Product Development";
        public string ReportingTo = "Zulquar Siddiquee";
        public double TotalExp = 0.7;

        public TechEmployees()
        {
            Console.WriteLine("Default Constructor");
        }

        public TechEmployees(string Designation, string ReportingTo, double TotalExp)
        {
            this.Designation = Designation;
            this.ReportingTo = ReportingTo;
            this.TotalExp = TotalExp;
            Console.WriteLine("Parameterized constructor");
        }

        public void TechEmpDisplay()
        {
            Console.WriteLine("Tech Employee details are displayed below: ");
            Console.WriteLine("Designation: " + Designation);
            Console.WriteLine("Reporting To: " + ReportingTo);
            Console.WriteLine("Total Experience in years: " + TotalExp);
        }
    }
}
