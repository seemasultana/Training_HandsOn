using System;

namespace ConsoleApp1
{

    public class TechEmployees : Employee

    {
        public string Designation = "Associate Engineer - Product Development";
        public string ReportingTo = "Zulquar Siddique";
        public string TotalExp = "8 months";
        public TechEmployees()
        {
            Console.WriteLine("Default constructor called");
        }
        public TechEmployees(string Designation, string ReportingTo, string TotalExp)
        {
            this.Designation = Designation;
            this.ReportingTo = ReportingTo;
            this.TotalExp = TotalExp;
        }
        public void Showdetails()
        {

            Console.WriteLine("Employee Designation: " + Designation);
            Console.WriteLine("Employee is Reporting To: " + ReportingTo);
            Console.WriteLine("Employee years of experience: " + TotalExp);
        }
    }
}
