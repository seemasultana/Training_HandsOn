using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace company
{
   
    public class TechEmployee : Employee
    {
        public string techdesignation;
        public string techreportingmanager;
        public string techtotalexp;
        public TechEmployee()
        {
            Console.WriteLine("employee role details");
        }
        public TechEmployee(string designation, string reportingmanager, string totalexp)
        {
            this.techdesignation = designation;
            Console.WriteLine("please enter employee disignation");
            this.techdesignation = Console.ReadLine();

            this.techreportingmanager = reportingmanager;
            Console.WriteLine("please enter employee reporting manager");
            this.techreportingmanager= Console.ReadLine();

            this.techtotalexp = totalexp;
            Console.WriteLine("please enter employee total experience");
            this.techtotalexp= Console.ReadLine();
        }
    }
}



