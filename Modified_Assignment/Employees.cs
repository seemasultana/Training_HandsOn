using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice1
{
    class Employee
    {
        public string Name;
        public string Gender;
        public string DateOfBirth;
        public int Age;
        public string EmailID;
        public string Password;
        public int EmpID;

        /* public int Age1
         {
             get { return Age; }
         }
         public string password1
         {
             set { Password = value; }
         }*/

        public Employee()
        {
            Console.WriteLine("Default constructor is called here");
        }

        public Employee(string name, string gender, string dateOfBirth, int age, string emailID, string password, int empID)
        {
            Name = name;
            Gender = gender;
            DateOfBirth = dateOfBirth;
            Age = age;
            EmailID = emailID;
            Password = password;
            EmpID = empID;
            Console.WriteLine("Parameterized constructor is called here");
        }

        public void Display()
        {
            Console.WriteLine("Name=" + Name);
            Console.WriteLine("Gender=" + Gender);
            Console.WriteLine("Date Of Birth=" + DateOfBirth);
            Console.WriteLine("Age=" + Age);
            Console.WriteLine("Email ID=" + EmailID);
            Console.WriteLine("Employee ID=" + EmpID);
            Console.WriteLine("Password=" +Password);
        }

        

    }
}
