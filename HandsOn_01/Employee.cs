using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sunanda
{
    class Employee
    {
        public string Name;
        public string Gender;
        public string DateOfBirth;
        public int Age;
        public string Email;
        public string Password;
        public int EmpId;

        public int Age1
        {
            get { return Age; }
        }

        public string password1
        {
            set { Password = value; }
        }

        public Employee()
        {

        }


        public Employee(string Nm, string Gd, string DOB, int Ag, string Eml, string Pd, int EI)
        {
            Name = Nm;
            Gender = Gd;
            DateOfBirth = DOB;
            Age = Ag;
            Email = Eml;
            Password = Pd;
            EmpId = EI;
           // Console.WriteLine("Parameterised constructor is called here");
        }
        public void Display()
        {
            Console.WriteLine("Name=" + Name);
            Console.WriteLine("Gender=" + Gender);
            Console.WriteLine("DateOfBirth=" + DateOfBirth);
            Console.WriteLine("Age=" + Age);
            Console.WriteLine("Email=" + Email);
            Console.WriteLine("Password=" + Password);
            Console.WriteLine("EmpId=" + EmpId);
        }


        




    }
}
