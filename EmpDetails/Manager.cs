using System;
using System.Collections.Generic;

namespace EmpDetails
{
    class Manager:Employee
    {
        public string Department;
        public string Title;
        public int Reportees;
        public int TotalExp;

        public Manager()
        {

        }

        public Manager(int empId, string name, string gender, string dateOfBirth, int age, string email, string password, string department, string title, int reportees, int totalExp)
        {
            EmpId = empId;
            Name = name;
            Gender = gender;
            DateOfBirth = dateOfBirth;
            Age = age;
            Email = email;
            Password = password;
            Department = department;
            Title = title;
            Reportees = reportees;
            TotalExp = totalExp;
        }
        public void Model()
        {
            Console.WriteLine("Reportees Detail:");
            Employee E1 = new Employee() {Name = "Rajasutha", Email = "raji@harman.com", Age = 22 };
            Employee E2 = new Employee() {Name = "sutha", Email = "sutha@harman.com", Age = 24 };
            Employee E3 = new Employee() {Name = "Praveen",Email = "praveen@harman.com",Age = 26 };
            Employee E4 = new Employee() {Name = "vigan", Email = "vigan@harman.com",Age = 28 };
            List<Employee> Employees = new List<Employee>();
            Employees.Add(E1);
            Employees.Add(E2);
            Employees.Add(E3);
            Employees.Add(E4);
            for (int i = 0; i < Employees.Count; i++)
            {
                Employee employee = Employees[i];
                Console.WriteLine($"Name = {employee.Name}, Email= {employee.Email}, Age= {employee.Age}");
            }

        }
        public void PrintManager()
        {
            Console.WriteLine("Enter Manager Details:");
            PrintEmployee();
            Model();
            Console.WriteLine("Department:" + Department + "\nTitle:" + Title + "\nReportees:" + Reportees + "\nTotalExp:" + TotalExp);
        }

    }
}
