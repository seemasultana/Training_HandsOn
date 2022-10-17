using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeConsoleApp
{
    public class TechEmployees : Employee
    {
        public string Designation = "Senior manager: product lead";
        public string ReportingTo = "T series music";
        public double TotalExp = 1.5;


        public TechEmployees()
        {
            Console.WriteLine(" Default Construrtor ");
        }

        public TechEmployees(string designation, string reportingTo, double totalExp)
        {
            Designation = designation;
            ReportingTo = reportingTo;
            TotalExp = totalExp;
            Console.WriteLine(" Paramterized Constructor");
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
