using employeees.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace employeees
{
    public class Manager : Employee
    {

        public string Department;
        public string Title;
        public int Reportees;
        public int TotalExp;
        public Manager()//default constructor
        {

        }
        public Manager(string name, char gender, string dateOfBirth, int age,
                string email, string password, int empId,
                string department, string title,
                int totalExp)
        {
            this.EmpAccept(name, gender, dateOfBirth, age, email, password, empId);
            this.Department = department;
            this.Title = title;
            this.TotalExp = totalExp;
        }
        public void ManagerDisp()
        {
            Console.WriteLine("...Manager details...\n");
            EmpDisp();
            Console.WriteLine("Department : " + this.Department);
            Console.WriteLine("ReportingTo : " + this.Title);
            Console.WriteLine("Reportees :");
            Mlist();
            Console.WriteLine("TotalExp : " + this.TotalExp);
        }
        public void Mlist()
        {
            report emp1 = new report()
            {
                Eid = 990,
                EName = "gayana",
                Eage = 22
            };
            report emp2 = new report()
            {
                Eid = 991,
                EName = "abc",
                Eage = 23
            };
            List<report> lst = new List<report>();
            lst.Add(emp1);
            lst.Add(emp2);
            foreach (report r in lst)
            {
                Console.WriteLine("Eid={0}\nEName={1}\nEage={2}\n", r.Eid, r.EName, r.Eage);
            }
        }
    }
    }

