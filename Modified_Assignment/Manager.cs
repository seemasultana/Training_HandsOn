using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice1
{
    class Manager : Employee
    {

        public string Department;
        public string Title;
        public int Reportees;
        public int TotalExp;

        public Manager()
        {
            Console.WriteLine("Default constructor is called here");
        }
        public Manager(string name, string gender, string dateOfBirth, int age,
            string emailID, int empID, string password, string department, string title, int totalExp)
        {
            Name = name;
            Gender = gender;
            DateOfBirth = dateOfBirth;
            Age = age;
            EmailID = emailID;
            EmpID = empID;
            Password = password;
            Department = department;
            Title = title;
            TotalExp = totalExp;
            Console.WriteLine("Parameterized contructor is called here");
        }

        public void ManDisplay()
        {
            Console.WriteLine("");
            Console.WriteLine("   Manager details      ");
            Console.WriteLine("   ~~~~~~~~~~~~~~~      ");
            Display();
            Console.WriteLine("Department=" + Department);
            Console.WriteLine("Title=" + Title);
            Console.WriteLine("Reportees---");
            Console.WriteLine("---------");
            Console.WriteLine("");
            Reportees1();
            Console.WriteLine("Total years of enperience=" + TotalExp);

        }

        public void Reportees1()
        {
            Memployee Memp1 = new Memployee()
            {
                EmpID = 1,
                EmpName = "Sourabh",
                EmpDob = 05 - 07 - 2000
            };
            Memployee Memp2 = new Memployee()
            {
                EmpID = 2,
                EmpName = "Shaili",
                EmpDob = 10 - 03 - 1996
            };
            Memployee Memp3 = new Memployee()
            {
                EmpID = 3,
                EmpName = "Saloni",
                EmpDob = 25 - 08 - 1998
            };


            List<Memployee> Customers = new List<Memployee>(2);
            Customers.Add(Memp1);
            Customers.Add(Memp2);
            Customers.Add(Memp3);


            foreach (Memployee c in Customers)
            {
                Console.WriteLine("\tID={0}\n \tName={1}\n \tDateOfBirth={2}\t\n", c.EmpID, c.EmpName, c.EmpDob);
            }

        }
    }

}
