using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeAssignment
{
    internal class Employee
    {
        public string Name { get; set; }
        public string Gender { get; set; }
        public string DateOfBirth { get; set; }
        public int Age;
        public int age
        {
            get 
            { 
                return Age;
            }
        }

        public string Email { get; set; }
        public string Password;
        public string password {
            set
            {
                Password = value;
            }
           
        }
        public int EmployeeId { get; set; }

        public Employee()
        {
    
        }

        
        public Employee(string name, string gender, string dateOfBirth, int age, string email, string password, int employeeId)
        {
            Name = name;
            Gender = gender;
            DateOfBirth = dateOfBirth;
            Age = age;
            Email = email;
            Password = password;
            EmployeeId = employeeId;
        }

        public void AcceptDetails(string name, string gender, string dateOfBirth, int age, string email, string password, int employeeId)
        {
            this.Name = name;   
            this.Gender = gender;
            this.DateOfBirth = dateOfBirth;
            this.Age = age;
            this.Email = email;
            this.Password = password;
            this.EmployeeId = employeeId;

        }
        public void DisplayDetails(int EmployeeId)
        {
            Console.WriteLine();
            Console.WriteLine("Name: " +this.Name);
            Console.WriteLine("Gender: "+ this.Gender);
            Console.WriteLine("Date of Birth: "+ this.DateOfBirth);
            Console.WriteLine("Age: "+ this.Age);
            Console.WriteLine("Email: " + this.Email);
            Console.WriteLine("Employee ID: " +this.EmployeeId);
        }
    }
}
