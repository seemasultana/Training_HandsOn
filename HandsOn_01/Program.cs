using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sunanda
{
    class Employee
    {
        public string Name = "Sunanda";
        public string Gender = "Female";
        public string DateOfBirth = "22-12-1999";
        public int Age = 22;
        public string Email = "Sunanda.Agolu@harman.com";
        public string Password;
        public int EmpId = 99018000;

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
            Console.WriteLine("Default constructor is called here");

        }
        public Employee(string Name, string Gender, string DateOfBirth, int Age, string Email, string Password, int EmpId)
        {
            this.Name = Name;
            this.Gender = Gender;
            this.DateOfBirth = DateOfBirth;
            this.Age = Age;
            this.Email = Email;
            this.Password = Password;
            this.EmpId = EmpId;
            Console.WriteLine("Parameterised constructor is called here");
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


        public static void Main(string[] args)
        {
            TechEmployees emp = new TechEmployees();
            Manager emp1 = new Manager();
            Console.WriteLine("Enter the Employee Id = ");
            emp.Password = "asasas";
    
            int empid = Convert.ToInt32(Console.ReadLine());
            if (empid == emp.EmpId)
            {
                emp.Display();
                emp.display();
                emp1.ddisplay();
            }
            else
            {
                Console.WriteLine("The emplyee Id is incorrect");
                 
            }
            Console.WriteLine("All the information is displayed");
        }
        

         
            
        
    }
}


