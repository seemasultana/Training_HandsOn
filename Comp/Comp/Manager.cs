using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace handson1
{
    public class Manager : Employee
    {
        public string Department;
        public string Title;
        public string Reportees;
        public int TotalExp;
        public Manager()
        {
            Console.WriteLine("default constructor for manager class");
        }
        public Manager(string name, string gender, string dateOfBirth, string email, string password, int employeeId, string department, string title, string reportees, int totalExp)
        {
            this.Name = name;
            this.Gender = gender;
            this.DateOfBirth = dateOfBirth;
            this.Email = email;
            this.Password = password;
            this.EmployeeId = employeeId;
            this.Department = department;
            this.Title = title;
            this.Reportees = reportees;
            this.TotalExp = totalExp;
        }
        public void InsertManager()
        {
            InsertManager();
            Console.WriteLine("Enter The Department: ");
            Department = Console.ReadLine();
            Console.WriteLine("Enter The Title: ");
            Title = Console.ReadLine();
            Console.WriteLine("Enter The Reportees: ");
            Reportees = Console.ReadLine();
            Console.WriteLine("Enter The total Experience: ");
            TotalExp = Convert.ToInt32(Console.ReadLine());

        }
        public void DisplayManager()
        {

            Console.WriteLine("Details Of Manager:");
            DisplayManager();
            Console.WriteLine("Department:" + Department);
            Console.WriteLine("Title:" + Title);
            Console.WriteLine("Reportees:" + Reportees);
            Console.WriteLine("TotalExp:" + TotalExp);
        }
    }
}