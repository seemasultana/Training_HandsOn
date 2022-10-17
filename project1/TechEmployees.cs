using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Assignment1
{
    internal class TechEmployees : Employee
    {
        public string Designation;
        public string ReportingTo;
        public int TotalExp;
        public TechEmployees()
        {
            
        }

        public TechEmployees(string name, string gender, string dob, int age, string email, string password, int empid, string designation, string reportingto, int totalexp)
        {
            this.Name = name;
            this.Gender = gender;
            this.Email = email;
            this.DateOfBirth = dob;
            this.Age = age;
            this.Email = email;
            this.Password = password;
            this.EmpId = empid;
            this.Designation = designation;
            this.ReportingTo = reportingto;
            this.TotalExp = totalexp;
        }

        public override void acceptdetails()
        {

            base.acceptdetails();
            Console.WriteLine("enter the reporting manager name");
            string r1 = Console.ReadLine();
            Console.WriteLine("enter the designation");
            string d1 = Console.ReadLine();
            Console.WriteLine("enter the years of experience");
            int e1 = Convert.ToInt32(Console.ReadLine());
            

            
        }

        public override void displaydetails()
        {
            base.displaydetails();
            Console.WriteLine("DESIGNATION : " + Designation);
            Console.WriteLine("EXPERIENCE(YEARS) : " + TotalExp);
            Console.WriteLine("REPORTING TO : " + ReportingTo);
        }



    }
}
