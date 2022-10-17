using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice1
{
    class Manager : Employee
    {
        public string Department = "Engineering";
        public string Title = "Associate Director";
        public int Reportees = 50;
        public int TotalExp = 10;

        public Manager()
        {
            Console.WriteLine("Default constructor is called here");
        }
        public Manager(string Department, string Title, int Reportees, int TotalExp)
        {
            this.Department = Department;
            this.Title = Title;
            this.Reportees = Reportees;
            this.TotalExp = TotalExp;
            Console.WriteLine("Parameterized contructor is called here");
        }

        public void ddisplay()
        {
            Console.WriteLine("");
            Console.WriteLine("      Manager details      ");
            Console.WriteLine("Department=" +Department);
            Console.WriteLine("Title="+ Title);
            Console.WriteLine("Reportees=" + Reportees);
            Console.WriteLine("Total years of enperience="+TotalExp);

        }
    }
    
}
