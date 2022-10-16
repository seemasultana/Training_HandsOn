using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    internal class Manager:Employee
    {
        public string Department;
        public string Title;
        public int TotalExp;
        public string Reportees;
        public Manager()
        {

        }

        public Manager(string name, string gender, string dob, int age, string email, string password, int empid, string department, string title, int totalexp, string reportees)
        {
            this.Name = name;
            this.Gender = gender;
            this.Email = email;
            this.DateOfBirth = dob;
            this.Age = age;
            this.Email = email;
            this.Password = password;
            this.EmpId = empid;
            this.Department = department;
            this.Title = title;
            this.TotalExp = totalexp;
            this.Reportees = reportees;
        }

        public override void acceptdetails()
        {
            base.acceptdetails();
            Console.WriteLine("enter the department");
            string d2 = Console.ReadLine();
            Console.WriteLine("enter the title");
            string t1 = Console.ReadLine();
            Console.WriteLine("enter experience(years");
            int e3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter reportees name");
            string r2 = Console.ReadLine();

        }

        public override void displaydetails()
        {
            base.displaydetails();
            Console.WriteLine("DEPARTMENT : " + Department);
            Console.WriteLine("TITLE : " + Title);
            Console.WriteLine("EXPERIENCE(YEARS) : " + TotalExp);
            Console.WriteLine("REPORTEES : " + Reportees);
        }

    }
}
