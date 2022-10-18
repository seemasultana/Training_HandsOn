using System;
using System.Collections.Generic;
using System.Text;

namespace ConstructorExample
{
    public class Employee
    {
        public int MyProperty { get; set; }
        public string Name;
        public string Gender;
        public string DateOfBirth;
        public readonly int age;
        public string Email;
        public string Password;
        public int EmpId;
        public int ReadOnlyAge
        {
            get { return age; }
        }

        public string WriteOnlyPassword
        {
            set { Password = value; }
        }

        public Employee() { }
        public Employee(string Nm, string gender, string DoB, int Age, string email,string pwd, int empId)
        {
            Name = Nm;
            Gender = gender;
            DateOfBirth = DoB;
            age = Age;
            Email = email;
            Password = pwd;
            EmpId = empId;
        }
        public void Display()
        {
            
            Console.WriteLine("Employee Name: " + Name);
            Console.WriteLine("Employee Gender: " + Gender);
            Console.WriteLine("Employee DOB: " + DateOfBirth);
            Console.WriteLine("Employee Age: " + age);
            Console.WriteLine("Employee EMailID: " + Email);
            Console.WriteLine("Password: " + Password);
            Console.WriteLine("Employee ID: " + EmpId);
        }
    }

}
