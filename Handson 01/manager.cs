using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace company
{
    public class Managerdetails: Employee
    {
        public string department;
        public string title;
        public string reportees;
        public string totalexp;
        public Managerdetails()
        {
            Console.WriteLine("Manager details");
        }
        public Managerdetails(string department, string title, string reportees, string totalexp)
        {
           this.department = department;
           Console.WriteLine("please enter manager department");
           this.department=Console.ReadLine();

           this.title = title;
           Console.WriteLine("please enter manager designation");
           this.title=Console.ReadLine();

           this.reportees = reportees;
           Console.WriteLine("please enter manager reportees");
           this.reportees = Console.ReadLine();

            this.totalexp = totalexp;
            Console.WriteLine("please enter manager total experience");
            this.totalexp = Console.ReadLine();
        }
    }
}

