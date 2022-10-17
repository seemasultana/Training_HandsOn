using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Assig1
{
    public class Employee
    {
        public string Name = "Bhoomika Yadwad";
        public string Gender = "Female";
        public string DateOfBirth = "21June2000";
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
            Console.WriteLine("Default Constructor");
        }

        //Parameterized Constructor
        public Employee(string Name, string Gender, string DateOfBirth, int Age, string Email, string Password, int EmpId)
        {
            this.Name = Name;
            this.Gender = Gender;
            this.DateOfBirth = DateOfBirth;
            this.Age = Age;
            this.Email = Email;
            this.EmpId = EmpId;
            Console.WriteLine("Parameterized constructor");
        }

        public void EmpDisplay()
        {
            Console.WriteLine("Employee details are displayed below: ");
            Console.WriteLine("Employee Name: " + Name);
            Console.WriteLine("Employee Gender: " + Gender);
            Console.WriteLine("Employee DOB: " + DateOfBirth);
            Console.WriteLine("Employee Age: " + Age);
            Console.WriteLine("Employee Email: " + Email);
            Console.WriteLine("Employee ID: " + EmpId);
        }
    }
}
