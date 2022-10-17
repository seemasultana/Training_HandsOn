using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice1
{
    class TechEmployees : Employee
    {
        public string Designation = "Associate Engineer";
        public string ReportingTo = "Zulquar Siddiquee";
        public int TotalExp = 0;



        public TechEmployees()
        {
            Console.WriteLine("Default constructor is called here");
        }

        public TechEmployees(string designation, string reportingTo, int totalExp)
        {
            this.Designation = designation;
            this.ReportingTo = reportingTo;
            this.TotalExp = totalExp;
            Console.WriteLine("Parameterized constructor is called here");
        }

        public void display()
        {
            Console.WriteLine("");
            Console.WriteLine("      Employee Details       ");
            Console.WriteLine("Designation=" + Designation);
            Console.WriteLine("Reporting To=" + ReportingTo);
            Console.WriteLine("Total Emperience=" + TotalExp);
        }
    }
}
