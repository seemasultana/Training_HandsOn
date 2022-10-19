using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalAssig1
{
    public class Manager : Employee
    {
        public string Department;
        public string Title;
        public string Reportees;
        public int TotalExp;

        public Manager()
        {
            Console.WriteLine("\nDefault Constructor");
        }

        public Manager(string name, string gender, string dateOfBirth, int age, string email, string password, int empId, string department, string title, string reportees, int totalexp)
        {
            Name = name;
            Gender = gender;
            DateOfBirth = dateOfBirth;
            Age = age;
            Email = email;
            Password = password;
            EmpId = empId;
            Department = department;
            Title = title;
            Reportees = reportees;
            TotalExp = totalexp;
        }

        public string Reportee()
        {
            List<ReporteeMClass> ReporteeList = new List<ReporteeMClass>();

            var r1 = new ReporteeMClass()
            {
                name = "Bhoomika",
                empid = "99021719",
                desig = "Associate Engineer"
            };
            var r2 = new ReporteeMClass()
            {
                name = "Anin",
                empid = "99019090",
                desig = "Associate Engineer"
            };
            var r3 = new ReporteeMClass()
            {
                name = "Chirag",
                empid = "99021718",
                desig = "Associate Engineer"
            };
            ReporteeList.Add(r1);
            ReporteeList.Add(r2);
            ReporteeList.Add(r3);

            foreach (var r in ReporteeList)
            { 
                Console.WriteLine("Reportee Name: {0}, Reportee EmpId: {1},Reportee Designation: {2}", r.name, r.empid, r.desig);
            }
            return Convert.ToString(ReporteeList);

        }

        public void ManagerDisplay()
        {
            EmpDisplay();
            Console.WriteLine("\nManager details are displayed below: ");
            Console.WriteLine("Department: " + Department);
            Console.WriteLine("Title: " + Title);
            Console.WriteLine("Total Experience in years: " + TotalExp);
            Console.WriteLine("\nThe following are the reportees of the manager: ");
            Reportee();
           

        }
    }
}
