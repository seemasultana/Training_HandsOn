using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Employee
{
    public class Employee
    {
        public string Name = "Leela";
        public string Gender = "Female";
        private int Age = 21; //readonly
        public string Dob = "05/01/2001";
        public string Email = "Leelarenu05@gmail.com";
        private string Password;//writeonly
        public int EmpId = 99021710;
        public int _age
        {
            get 
            { 
                return Age; 
            }
            
        }
        public string _password // write-only property
        {
            /*get 
            { 
                return Password; 
            }*/

            set
            {
                Password = value;
            }
        }
        public Employee()
        {

        }

        public Employee(string name, string gender, int age,string dob, string email, int empId)
        {
            Name = name;
            Gender = gender;
            Age = age;
            Dob = dob;
            Email = email;
            EmpId = empId;

        }
        public void DisplayEmployee()
        {
            Console.WriteLine("\nEmployee Details:");
            Console.WriteLine("Name:"+Name);
            Console.WriteLine("Gender:"+Gender);
            Console.WriteLine("Age:"+_age);
            Console.WriteLine("Date Of Birth:"+Dob);
            Console.WriteLine("Employee ID:"+EmpId);
        }

    }

    public class TechEmployees : Employee   //derived class
    {
        public string Designation = "Associate Engineer";
        public string ReportingTo = "Zulquar";
        public int TotalExp = 5;

        public TechEmployees()
        {

        }

        public TechEmployees(string designation, string reportingTo, int totalExp)
        {
            Designation = designation;
            ReportingTo = reportingTo;
            TotalExp = totalExp;
        }

        public void DisplayTechEmployees()
        {
            Console.WriteLine("\nTech Employee Details:");
            Console.WriteLine("Designation:"+Designation);
            Console.WriteLine("Reporting To:"+ReportingTo);
            Console.WriteLine("Total Experience:"+TotalExp);
        }
    }

    public class Manager : Employee
    {
        public string Department = "DTS";
        public string Title = "Senior Manager";
        public string Reportees = "20";
        public int TotalExp = 15;

        public Manager()
        {

        }

        public Manager(string department, string title, string reportees, int totalExp)
        {
            Department = department;
            Title = title;
            Reportees = reportees;
            TotalExp = totalExp;
        }

        public void DisplayManager()
        {
            Console.WriteLine("\nManager Details:");
            Console.WriteLine("Department:"+Department);
            Console.WriteLine("Title:"+Title);
            Console.WriteLine("Reportees:"+Reportees);
            Console.WriteLine("Total Experience:"+TotalExp);
        }

        class Program
        {
            static void Main(string[] args)
            {
                Employee emp = new Employee();
                TechEmployees tech = new TechEmployees();
                Manager manager = new Manager();

                manager.DisplayManager();
                tech.DisplayTechEmployees();
                
                //Console.WriteLine(tech._password = "Leela@123");

                Console.WriteLine("\nEnter the Emp Id :");
                Double EmployeeId = Convert.ToDouble(Console.ReadLine());
                if (EmployeeId == tech.EmpId)
                {
                    tech.DisplayEmployee();
                }
                else
                {
                    Console.WriteLine("Invalid Employee ID");
                }

                

                Console.ReadLine();

                
                //Console.WriteLine(emp._age);
                //Console.WriteLine(emp._password);
            }
        }
    }
}

