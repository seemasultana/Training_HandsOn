using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice1
{
    class Employee
    {
        public string Name = "Anindita Gogoi";
        public string Gender = "Female";
        public string DateOfBirth = "27-06-2000";
        public readonly int Age = 21;
        public string EmailID = "Anindita.Gogoi@harman.com";
        public string Password;
        public int EmpID = 99021720;

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

        public Employee(string Name, string Gender, string DateOfBirth, int Age, string EmailID, int EmpID)
        {
            this.Name = Name;
            this.Gender = Gender;
            this.DateOfBirth = DateOfBirth;
            this.Age = Age;
            this.EmailID = EmailID;
            this.EmpID = EmpID;
            Console.WriteLine("Parameterized constructor is called here");
        }

        public void Display()
        {
            Console.WriteLine("Name=" + Name);
            Console.WriteLine("Gender=" + Gender);
            Console.WriteLine("Date Of Birth=" + DateOfBirth);
            Console.WriteLine("Age=" + Age);
            Console.WriteLine("Email ID=" + EmailID);
            Console.WriteLine("Password=" + Password);
            Console.WriteLine("Employee ID=" + EmpID);
        }

        public static void Main(string[] args)
        {
            
            TechEmployees emp = new TechEmployees();
            Manager emp1 = new Manager();
            Console.Write("Enter the Employee Id = ");
            emp.Password = "aaaaaa";
            int empid=Convert.ToInt32(Console.ReadLine());
            if (empid == emp.EmpID)
            {
                
                emp.Display();
                emp.display();
                emp1.ddisplay();
            }
            else
            {
                Console.WriteLine("The Employee ID is incorrect");
            }
            Console.WriteLine("All the information are displayed");
        }

    }
}
