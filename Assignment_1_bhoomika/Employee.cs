using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assig1Final
{
    public class Employee
    {
        public string Name = "Bhoomika Yadwad";
        public string Gender = "Female";
        public string DateOfBirth = "21 June 2000";
        public int Age = 22;
        public string Email = "Bhoomika.Yadwad@harman.com";
        public int EmpId = 99021719;
        public string Password;

        //read only
        public int Agee
        {
            get { return Age; }
        }

        //write only
        public string Passwordd
        {
            set { Password = value; }
        }

        //Default Constructor
        public Employee()
        {
            Console.WriteLine("\nDefault Constructor 1");
        }

        //Parameterized Constructor
        public Employee(string name, string gender, string dateOfBirth, int age, string email, string password, int empId)
        {
            Name = name;
            Gender = gender;
            DateOfBirth = dateOfBirth;
            Age = age;
            Email = email;
            Password = password;
            EmpId = empId;
        }

        public void EmpDisplay()
        {
            Console.WriteLine("\nEmployee details are displayed below: ");
            Console.WriteLine("Employee Name: " + Name);
            Console.WriteLine("Employee Gender: " + Gender);
            Console.WriteLine("Employee DOB: " + DateOfBirth);
            Console.WriteLine("Employee Age: " + Age);
            Console.WriteLine("Employee Email: " + Email);
            Console.WriteLine("Employee ID: " + EmpId);
        }
    }

}
