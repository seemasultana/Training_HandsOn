using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace TejasiAssignment1
{
    internal class Manager: Employee
    {
        public string Department;
        public string Title;
        public int Reportees;
        public int TotalExperience;
        public Manager()
        {
            Console.WriteLine("Default Constructor of Manager Child Class");
        }
        public Manager(string department, string title, int reportees, int totalExperience)
        {
            this.Department = department;
            this.Title = title;
            this.Reportees = reportees;
            this.TotalExperience = totalExperience;
        }
        public  void   Managerinfo(string Department, string Title, int Reportees, int TotalExperience)
        {
            Console.WriteLine("Manager Department is: " + " " + Department);
            Console.WriteLine("The title is " + " " + Title);
            Console.WriteLine("The number of Reportees are : " + " " + Reportees);
            Console.WriteLine("The total Experience he has of:" + " " + TotalExperience+  " "+ "years");
        }

        
    }
}
