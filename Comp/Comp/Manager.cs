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
        }
        public Manager(string name, string gender, string dateOfBirth, string email,int age, string password, int employeeId, string department, string title,string reportees, int totalExp)
        {
            Name = name;
            Gender = gender;
            DateOfBirth = dateOfBirth;
            Email = email;
            Password = password;
            EmployeeId = employeeId;
            Department = department;
            Title = title;
            
            Reportees = reportees;
            TotalExp = totalExp;
        }

        //public void Method()
        //{
        //    Console.WriteLine("Reportees are:");
        //    Employee A1 =new Employee() { Name = "Arjun"}
        //    Employee A2 =new Employee();
        //    Employee A3 =new Employee();
        //    Employee A4 =new Employee();

        //}
        
        public void DisplayManager()
        {
            DisplayEmployee();

            Console.WriteLine("Details Of Manager:");

            Console.WriteLine("Name:" + Name);
            Console.WriteLine("Gender:" + Gender);
            Console.WriteLine("DateOfBirth:" + DateOfBirth);
            Console.WriteLine("Email:" + Email);
            Console.WriteLine("Age:" + Age);
            Console.WriteLine("Password" + Password);
            Console.WriteLine("EmployeeId:" + EmployeeId);
            Console.WriteLine("Department:" + Department);
            Console.WriteLine("Title:" + Title);
            Console.WriteLine("Reportees:" + Reportees);
            Console.WriteLine("TotalExp:" + TotalExp);
        }
    }
}