using System;
using System.Runtime.CompilerServices;
using System.Text;


namespace EmployeeConsoleApp
{
        public class Employee
        {
            public string Name;
            public string Gender;
            public string DateOfBirth;
            public  int Age;
            public string Email;
            public int EmpId;
            public string Password;


        public Employee()
        {
            
        }

        public Employee(string name, string gen, string dob,int age, string email,string password, int empId)
        {
            Name = name;
            Gender = gen;
            DateOfBirth = dob;
            Age = age;
            Email = email;
            Password = password;
            EmpId = empId;

        }

        public void EmpDisplay()
        {
            Console.WriteLine("\n The employee details are:");
            Console.WriteLine("Name of the Employee is: " + Name);
            Console.WriteLine("Gender of the Employee is: " + Gender);
            Console.WriteLine("Date of birth of the employee is: " + DateOfBirth);
            Console.WriteLine("Age of thr employee is: "+ Age);
            Console.WriteLine("Email ID Of the employee is: " + Email);
            Console.WriteLine("Employee Id of the employee is: " + EmpId);
        }
    }
}