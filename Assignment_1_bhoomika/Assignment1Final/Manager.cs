using Assig1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1Final
{
    public class Manager : Employee
    {
        public string Department = "DTS";
        public string Title = "Associate Director";
        public string Reportees = "45";
        public double TotalExp = 7.9;

        public Manager()
        {
            Console.WriteLine("Default Constructor");
        }

        public Manager(string department, string title, string reportees, double totalExp)
        {
            Department = department;
            Title = title;
            Reportees = reportees;
            TotalExp = totalExp;
        }

        public void ManagerDisplay()
        {
            Console.WriteLine("Manager details are displayed below: ");
            Console.WriteLine("Department: " + Department);
            Console.WriteLine("Title: " + Title);
            Console.WriteLine("Total Experience in years: " + TotalExp);
        }
    }
}
