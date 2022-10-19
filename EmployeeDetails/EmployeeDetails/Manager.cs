using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeDetails
{
    public class Manager : Employee
    {
        public string Department;
        public string Title;
        public int Reportees;
        public string TotalExperience;

        public Manager()
        {

        }


        public Manager(int empId, string name, string gender, string dob, int age, string email,string department, string title, int reportees, string totalExperience)
        {
            EmpId = empId;
            Name = name;
            Gender = gender;
            DateOfBirth = dob;
            Age = age;
            Email = email;
            Department = department;
            Title = title;
            Reportees = reportees;
            TotalExperience = totalExperience;
        }

        public void ReporteesDetails()
        {
            List<Manager> reportees = new List<Manager>();

            reportees.Add(new Manager
            {
                EmpId = 99021710,
                Name = "Leela"
            });

            reportees.Add(new Manager
            {
                EmpId = 99021149,
                Name = "Sudha"
            });

            foreach(var ViewReportees in reportees)
            {
                Console.WriteLine("EmpId={0},Name={1}",ViewReportees.EmpId, ViewReportees.Name );
            }

        }

        public void ManagerDetails()
        {
            Console.WriteLine("\nMANAGER DETAILS :");
            Console.WriteLine("\nEmpID:"+EmpId);
            Console.WriteLine("\nName:"+Name);
            Console.WriteLine("\nGender:"+Gender);
            Console.WriteLine("\nDate Of Birth:"+DateOfBirth);
            Console.WriteLine("\nAge:"+Age);
            Console.WriteLine("\nEmail:"+Email);
            Console.WriteLine("\nDepartment:"+Department);
            Console.WriteLine("\nTitle:"+Title);
            Console.WriteLine("\nReportees:");
            ReporteesDetails();
            Console.WriteLine("\nTotal Experience:"+TotalExperience);
        }




    }
}
