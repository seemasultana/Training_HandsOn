using System;

namespace ConsoleApp1
{ 
    public class Employee
    {
        public string Name = "Anamika";
        public string Gender = "Female";
        public string DOB = "21/07/2000";
        public readonly int age = 22;
        public string Email = "Anamika.Tripathi@harman.com";
        public string Password = " ";
        public int EmpId = 99018253;
        public int ReadOnlyAge
        {
            get { return age; }
        }

        public string WritePassword
        {
            set { Password = value; }
        }
        public Employee()
        {
            Console.WriteLine("Default constructor called ");
        }
        public Employee(string Name, string Gender, string DOB, int age, string Email, int EmpId)
        {
            this.Name = Name;
            this.Gender = Gender;
            this.DOB = DOB;
            this.age = age;
            this.Email = Email;
            this.EmpId = EmpId;
        }
        public void Display()
        {

            Console.WriteLine("Employee Name: " + Name);
            Console.WriteLine("Employee Gender: " + Gender);
            Console.WriteLine("Employee DOB: " + DOB);
            Console.WriteLine("Employee Age: " + age);
            Console.WriteLine("Employee EMailID: " + Email);
            Console.WriteLine("Password: " + Password);
            Console.WriteLine("Employee ID: " + EmpId);
        }
       
    }
}
