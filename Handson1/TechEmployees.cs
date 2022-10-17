using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sunanda
{

    class TechEmployees : Employee
    {
        public string Designation = "Associate Engineer";
        public string ReportingTo = "Zulquar Siddique";
        public int TotalExp = 0;
    
        public TechEmployees()
        {
            Console.WriteLine("Default constructor is called here");
        }
        public TechEmployees(string Designation, string ReportingTo, int TotalExp)
        {
            this.Designation = Designation;
            this.ReportingTo = ReportingTo;
            this.TotalExp = TotalExp;
            Console.WriteLine("Parameterised constructor is called here");
        }

        public void display()
        {
            Console.WriteLine("");
            Console.WriteLine("   Employee Details    ");
            Console.WriteLine("Designation=" + Designation);
            Console.WriteLine("ReportingTo= + Title");
            Console.WriteLine("Reportees=" + ReportingTo);
            Console.WriteLine("Total experience=" + TotalExp);
        }
    
    }
}
