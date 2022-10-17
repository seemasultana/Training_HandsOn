using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace employeees
{
    public class Employee
    {
        public string Name;
        public char Gender;
        public string DateOfBirth;
        public int Age;
        public string Password;
        public string Email;
        public int age
        {
            get { return Age; }
        }

        public string password
        {
            set { Password = value; }
        }
        public string EmpId;

        // Default constructor
        public Employee()
        {

        }

        // Parameterized constructor
        
        public  Employee(string Name, char Gender, string DateOfBirth, int Age,
               string Email, string Password, string EmpId)
        {
            this.Name = Name;
            this.Gender = Gender;
            this.DateOfBirth = DateOfBirth;
            this.Age = Age;
            this.Email = Email;
            this.Password = Password;
            this.EmpId = EmpId;
        }


        // Accept Details
        public void EmpAccept(string Name, char Gender, string DateOfBirth,
                int Age, string Email, string Password, string EmpId)
        {
            this.Name = Name;
            this.Gender = Gender;
            this.DateOfBirth = DateOfBirth;
            this.Age = Age;
            this.Email = Email;
            this.Password = Password;
            this.EmpId = EmpId;
        }

        // Display Details
        public void EmpDisp(string EmpId)
        {
            Console.WriteLine("Name : " + this.Name);
            Console.WriteLine("Gender : " + this.Gender);
            Console.WriteLine("DateOfBirth : " + this.DateOfBirth);
            Console.WriteLine("Age : " + this.Age);
            Console.WriteLine("Email : " + this.Email);
            Console.WriteLine("Password : " + this.Password);
            Console.WriteLine("EmpId : " + this.EmpId);
        }
    }

}

