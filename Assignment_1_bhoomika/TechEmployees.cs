using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assig1Final
{
    public class TechEmployees:Employee
    {
        public string Designation = "Associate Engineer:Product Development";
        public string ReportingTo = "Zulquar Siddiquee";
        public double TotalExp = 0.7;

        public TechEmployees()
        {
            Console.WriteLine("\nDefault Constructor 2");
        }

        public TechEmployees(string designation, string reportingTo, double totalExp)
        {
            Designation = designation;
            ReportingTo = reportingTo;
            TotalExp = totalExp;
            Console.WriteLine("\nParameterized constructor");
        }

        public void TechEmpDisplay()
        {
            Console.WriteLine("\nTech Employee details are displayed below: ");
            Console.WriteLine("Designation: " + Designation);
            Console.WriteLine("Reporting To: " + ReportingTo);
            Console.WriteLine("Total Experience in years: " + TotalExp);
        }
    }

}
