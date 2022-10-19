using EmployeeConsoleApp.MClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeConsoleApp
{
    public class Manager : Employee
    {
        public string Department;
        public string Title;
        public string Reportees;
        public double TotalExp;


        public Manager()
        {

        }

        public Manager(string name, string gen, string dob, int age, string email, string password, int empId, string department, string title, string reportees, int totalexp)
        {
            Name = name;
            Gender = gen;
            DateOfBirth = dob;
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
            List<ReporteesClassList> ReporteeList = new List<ReporteesClassList>();

            var rep1 = new ReporteesClassList()
            {
                name = "Bhoomika",
                empid = "99021719",
                desig = "Associate Engineer"
            };
            var rep2 = new ReporteesClassList()
            {
                name = "Anin",
                empid = "99019090",
                desig = "Associate Engineer"
            };
            var rep3 = new ReporteesClassList()
            {
                name = "Chirag",
                empid = "99021718",
                desig = "Associate Engineer"
            };
            ReporteeList.Add(rep1);
            ReporteeList.Add(rep2);
            ReporteeList.Add(rep3);

            foreach (var rep in ReporteeList)
            {
                Console.WriteLine("Reportee Name: {0}, Reportee EmpId: {1},Reportee Designation: {2}", rep1.name, rep2.empid, rep3.desig);
            }
            return Convert.ToString(ReporteeList);

        }


        public void ManagerDisplay()
        {
            Console.WriteLine("\n Manager details are: ");
            Console.WriteLine("Department is " + Department);
            Console.WriteLine("Title is " + Title);
            Console.WriteLine("Reportees are " + Reportees);
            Console.WriteLine("Total Expenses " + TotalExp);
        }
    }
}
