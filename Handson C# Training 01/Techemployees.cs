using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anu
{
    class TechEmployees : Employee
    {
        public string Designation = "Assossiate Engineer";

        public string ReportingTo = "Zulquer Siddique";

        public string TotalExp = "6 Months";


        public TechEmployees()
        {

            Console.WriteLine("Default constructor is called here");
        }

        public TechEmployees(string designation, string ReportingTo, string TotalExp)
        {
            this.Designation = designation;
            this.ReportingTo = ReportingTo;
            this.TotalExp = TotalExp;

        }



        public void TechEmployeedisplay()
        {
            Console.WriteLine("Techemployees Details : ");
            Console.WriteLine("designation =" + Designation);
            Console.WriteLine("ReportingTo =" + ReportingTo);
            Console.WriteLine("TotalExp =" + TotalExp);

        }




    }


}
