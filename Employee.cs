using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    internal class Employee
    {
        public string Name;
        public string Gender;
        public string DateOfBirth;
        public int Age;
        public string Email;
        public string Password;
        public int EmpId;

        public  Employee()
        {
            
        }

        public Employee(string name, string gender , string dob , int age , string email , string password, int empid)
        {
            this.Name = name;
            this.Gender = gender;   
            this.Email = email;
            this.DateOfBirth = dob;
            this.Age = age;
            this.Email = email;
            this.Password = password;
            this.EmpId = empid;
        }

        public  virtual void  acceptdetails()
        {
            Console.WriteLine("WELCOME TO HARMAN");
            Console.WriteLine("enter your name");
            string n = Console.ReadLine();
            Console.WriteLine("enter your employee ID");
            int id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter your gender");
            string g = Console.ReadLine();
            Console.WriteLine("enter your email");
            string e = Console.ReadLine();
            Console.WriteLine("enter your password");
            string p = Console.ReadLine();
            Console.WriteLine("enter your age");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter your DOB");
            string d = Console.ReadLine();


        }
        public virtual void displaydetails()
        {
            Console.WriteLine("NAME : " + Name);
            Console.WriteLine("EMPLOYEE ID : " + EmpId);
            Console.WriteLine("EMAIL - ID : " + Email);
            Console.WriteLine("DATE OF BIRTH : " + DateOfBirth);
            Console.WriteLine("GENDER : " + Gender);
            Console.WriteLine("AGE : " + Age);


        }
        
    }
}
