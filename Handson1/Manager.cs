using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sunanda
{
    class Manager : Employee
    {
        public string Department = "Engineering";
        public string Title = "Associate Engineer";
        public int Reportees = 50;
        public int TotalExp = 10;

        public Manager()
        {
            Console.WriteLine("Default constructor is called here");
        }

        public Manager(string department, string title, int reportees, int totalExp)
        {
            this.Department = department;
            this.Title = title;
            this.Reportees = reportees;
            this.TotalExp = totalExp;
            Console.WriteLine("Parameterised constructor is called here");
        }

        public void ddisplay()
        {
            Console.WriteLine("");
            Console.WriteLine("     Manager Details      ");
            Console.WriteLine("Department=" + Department);
            Console.WriteLine("Title=" + Title);
            Console.WriteLine("Reportees=" + Reportees);
            Console.WriteLine("Total years of experience=" + TotalExp);
        }
    }
}
