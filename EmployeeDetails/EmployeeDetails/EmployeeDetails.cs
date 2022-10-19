using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeDetails
{
    class EmployeeDetails
    {
        static void Main(string[] args)
        {



            Manager manager = new Manager(1234,"Zulquar","Male","18/11/1979",35,"abc@gmail.com","DTS","Manager",2,"12 years");

            List<TechEmployee> list1 = new List<TechEmployee>();
            List<TechEmployee> list2 = new List<TechEmployee>();
            List<TechEmployee> list3 = new List<TechEmployee>();

            list1.Add(new TechEmployee
            {
                EmpId = 99021710,
                Name = "Leela",
                Gender = "Female",
                DateOfBirth = "05/01/2001",
                Age = 21,
                Email = "leelarenu05@gmail.com",
                Designation = "Associate Engineer",
                ReportingTo = "Zulquar",
                TotalExperience = "5 months"

            });

            list2.Add(new TechEmployee
            {
                EmpId = 99021149,
                Name = "Sudha",
                Gender = "Female",
                DateOfBirth = "15/12/2000",
                Age = 21,
                Email = "sudha123@gmail.com",
                Designation = "Associate Engineer",
                ReportingTo = "Zulquar",
                TotalExperience = "8 months"

            });

            list3.Add(new TechEmployee
            {
                EmpId = 99021653,
                Name = "Sridharan",
                Gender = "Male",
                DateOfBirth = "18/11/2000",
                Age = 21,
                Email = "sridharan123@gmail.com",
                Designation = "Associate Engineer",
                ReportingTo = "Shilpa",
                TotalExperience = "10 months"

            });

            Console.WriteLine("\nEnter the Emp Id :");
            int EmployeeId = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine(list1[0].EmpId);
            
            if (EmployeeId == list1[0].EmpId)
            {
                foreach (var emp in list1)
                {
                    Console.WriteLine("\nEmployee Id:" + emp.EmpId);
                    Console.WriteLine("\nName:" + emp.Name);
                    Console.WriteLine("\nGender:" + emp.Gender);
                    Console.WriteLine("\nDate of Birth:" + emp.DateOfBirth);
                    Console.WriteLine("\nAge:" + emp.Age);
                    Console.WriteLine("\nEmail:" + emp.Email);
                    Console.WriteLine("\nDesignation:" + emp.Designation);
                    Console.WriteLine("\nReporting To:" + emp.ReportingTo);
                    Console.WriteLine("\nTotal Experience:" + emp.TotalExperience);
                    Console.WriteLine("\n****");
                }
            }
            else if (EmployeeId == list2[0].EmpId)
            {
                foreach (var emp in list2)
                {
                    Console.WriteLine("\nEmployee Id:" + emp.EmpId);
                    Console.WriteLine("\nName:" + emp.Name);
                    Console.WriteLine("\nGender:" + emp.Gender);
                    Console.WriteLine("\nDate of Birth:" + emp.DateOfBirth);
                    Console.WriteLine("\nAge:" + emp.Age);
                    Console.WriteLine("\nEmail:" + emp.Email);
                    Console.WriteLine("\nDesignation:" + emp.Designation);
                    Console.WriteLine("\nReporting To:" + emp.ReportingTo);
                    Console.WriteLine("\nTotal Experience:" + emp.TotalExperience);
                    Console.WriteLine("\n****");
                }

            }
            else if (EmployeeId == list3[0].EmpId)
            {
                foreach (var emp in list3)
                {
                    Console.WriteLine("\nEmployee Id:" + emp.EmpId);
                    Console.WriteLine("\nName:" + emp.Name);
                    Console.WriteLine("\nGender:" + emp.Gender);
                    Console.WriteLine("\nDate of Birth:" + emp.DateOfBirth);
                    Console.WriteLine("\nAge:" + emp.Age);
                    Console.WriteLine("\nEmail:" + emp.Email);
                    Console.WriteLine("\nDesignation:" + emp.Designation);
                    Console.WriteLine("\nReporting To:" + emp.ReportingTo);
                    Console.WriteLine("\nTotal Experience:" + emp.TotalExperience);
                    Console.WriteLine("\n****");
                }
            }

            else if (EmployeeId == manager.EmpId)
            {
                manager.ManagerDetails();
            }

            else
                {
                    Console.WriteLine("Invalid Employee ID");
                }
        }
    }
}

