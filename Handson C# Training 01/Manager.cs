using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anu
{
    public class Manager : Employee

    {
        public string Department = " Engineering";
        public string Title = "Associate Engineer";
        public int Reportees = 3;
        public int TotalExp = 10;


        public Manager()
        {
            Console.WriteLine("Default Constructor is Called here");
        }

        public Manager(string Department, string Title, int Reportees, int TotalExp)
        {
            this.Department = Department;
            this.Title = Title;
            this.Reportees = Reportees;
            this.TotalExp = TotalExp;


            Console.WriteLine("Parameterised Constructor is Called here");
        }
        public void Rinfo()
        {
            List<Reportees> reportees = new List<Reportees>();
            reportees.Add(new Reportees
            {
               empname = "Priya",
                empid = 99012345
            });
            reportees.Add(new Reportees
            {
                empname = "Hari",
                empid = 99034567
            });
            reportees.Add(new Anu.Reportees
            {
                empname = "Bhavya",
                empid = 99078912
            });
            foreach (var a in reportees)
            {
                Console.WriteLine("empname = {0}, empid = {1}", a.empname, a.empid);
            }
        }


            public void Managerdisplay()
            {
                Console.WriteLine(" Employee and Manager Detais ");
                 EmployeeDisplays();
                 Rinfo();
                Console.WriteLine("Department = " + Department);
                Console.WriteLine("Title = " + Title);
                Console.WriteLine("Reportees = " + Reportees);
                Console.WriteLine("TotalExp = " + TotalExp);
            }







        }
    }





