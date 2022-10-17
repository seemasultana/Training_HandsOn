using System;
using System.Runtime.CompilerServices;
using System.Text;


namespace EmployeeConsoleApp
{
    public class Employee
    {
        public string Name = "Lucky Ali";
        public string Gender = "Male";
        public string Dateofbirth = " 19th sept 1958";
        public readonly int Age;
        public string Email = "alilucky1958@gmail.com";
        public int EmpId = 2022987;
        public string Password;

        public int Age1 { get { return Age; } }

        public string Password1 { set { Password = value; } }


        public Employee()
        {
            Console.WriteLine("\n Default Constructor");
        }

        public Employee(string Name, string Gender, string DateofBirth, string Email, int EmpId)
        {
            this.Name = Name;
            this.Gender = Gender;
            this.Dateofbirth = DateofBirth;
            this.Email = Email;
            this.EmpId = EmpId;

        }

        public void EmpDisplay()
        {
            Console.WriteLine("\n The employee details are:");
            Console.WriteLine("Name of the Employee is: " + Name);
            Console.WriteLine("Gender of the Employee is: " + Gender);
            Console.WriteLine("Age of the employee is: " + Age);
            Console.WriteLine("Email ID Of the employee is: " + Email);
            Console.WriteLine("Employee Id of the employee is: " + EmpId);
        }
    }
}