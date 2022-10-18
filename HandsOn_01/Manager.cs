using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees
{
    public class Manager:Employee
    {
       public string Department;
       public string Title;
       public string Reportees;
       public int TotalExp;
        public Manager()
        {
            Console.WriteLine("This is a constructor for manager class");
        }
        public Manager(string name, string gender, string dateOfBirth, int age, string email, string password, int employeeId, string department, string title, string reportees, int totalExp)
        {
            Name = name;
            Gender = gender;
            DateOfBirth = dateOfBirth;
            Age = age;
            Email = email;
            Password = password;
            EmployeeId = employeeId;
            Department = department;
            Title = title;
            Reportees = reportees;
            TotalExp = totalExp;
        }
        public string Reportee()
        {
            List<ReporteeModelclass> Reporteelist = new List<ReporteeModelclass>();

            var a = new ReporteeModelclass()
            {
                name = "Rishabh",
                empid = "1011",
                role = "Assoc. Engineer"

            };
            var b = new ReporteeModelclass()
            {
                name = "Priyanka",
                empid = "1012",
                role = "Assoc. Engineer"
            };
            var c = new ReporteeModelclass()
            {
                name = "Arjun",
                empid = "1013",
                role = "Assoc. Engineer"
            };
            Reporteelist.Add(a);
            Reporteelist.Add(b);
            Reporteelist.Add(c);

            foreach (var d in Reporteelist)
            {
                Console.WriteLine("name={0},empid={1},role={2}", d.name, d.empid, d.role);
            }
            return Convert.ToString(Reporteelist);
        }
        public void InsertManager()
        {
            InsertEmployee();
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
            DisplayEmployee();
            Console.WriteLine("Department:"+ Department);
            Console.WriteLine("Title:"+ Title);
            Console.WriteLine("Reportees-:");
            Reportee();
            //Console.WriteLine("Reportees:"+ Reportees);
            Console.WriteLine("TotalExp:"+ TotalExp);
        }
    }
}
