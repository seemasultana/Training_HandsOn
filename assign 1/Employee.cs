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
        public int EmpId;

        // Default constructor
        public Employee()
        {

        }
        // Parameterized constructor
        public  Employee(string name, char gender, string dateOfBirth, int age,
               string email, string password, int empId)
        {
            this.Name = name;
            this.Gender = gender;
            this.DateOfBirth = dateOfBirth;
            this.Age = age;
            this.Email = email;
            this.Password = password;
            this.EmpId = empId;
        }
        public void EmpAccept(string name, char gender, string dateOfBirth,
                int age, string email, string password, int empId)
        {
            this.Name = name;
            this.Gender = gender;
            this.DateOfBirth = dateOfBirth;
            this.Age = age;
            this.Email = email;
            this.Password = password;
            this.EmpId = empId;
        }
        public void EmpDisp()
        {
            Console.WriteLine("Name : " + Name);
            Console.WriteLine("Gender : " + this.Gender);
            Console.WriteLine("DateOfBirth : " + this.DateOfBirth);
            Console.WriteLine("Age : " + this.Age);
            Console.WriteLine("Email : " + this.Email);
            Console.WriteLine("Password : " + this.Password);
            Console.WriteLine("EmpId : " + this.EmpId);
        }
    }

}

