using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalAssig1
{
    public class Employee
    {
        public string Name;
        public string Gender;
        public string DateOfBirth;
        public int Age;
        public string Email;
        public int EmpId;
        public string Password;

        /*read only
        public int Agee
        {
            get { return Age; }
        }

        //write only
        public string Passwordd
        {
            set { Password = value; }
        }*/

        //Default Constructor
        public Employee()
        {
            Console.WriteLine("\nDefault Constructor");
        }

        //Parameterized Constructor
        public Employee(string name, string gender, string dateOfBirth, int age, string email, string password, int empId)
        {
            Name = name;
            Gender = gender;
            DateOfBirth = dateOfBirth;
            Age = age;
            Email = email;
            EmpId = empId;
            Console.WriteLine("Parameterized constructor");
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
