using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeConsoleApp
{
    public class Manager : Employee
    {
        public string Department = "Music";
        public string Title = "Music Director";
        public string Reportees = "22";
        public double TotalExp = 9.9;


        public Manager()
        {
            Console.WriteLine("\n Default Construtor");
        }

        public Manager(string Department, string Title, string Reportees, double TotalExp)
        {
            this.Department = Department;
            this.Title = Title;
            this.Reportees = Reportees;
            this.TotalExp = TotalExp;
        }

        public void ManagerDisplay()
        {
            Console.WriteLine("\n Manager details are: ");
            Console.WriteLine("Department is " + Department);
            Console.WriteLine("Title is " + Title);
            Console.WriteLine("Reportees are " + Reportees);
            Console.WriteLine("Total Expenses " + TotalExp);
        }
    }
}
