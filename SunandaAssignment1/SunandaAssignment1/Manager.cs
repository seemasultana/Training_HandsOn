using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SunandaAssignment1
{

    class Manager : Employee
    {
        public string Department = "Engineering";
        public string Title = "Associate Engineer";
        public int Reportees = 50;
        public int TotalExp = 10;



        public Manager(string Nm, string Gd, string DOB, int Ag, string Eml, string Pd, int EI, string dpt, string ttl, int rpts, int ttlExp)
        {
            Name = Nm;
            Gender = Gd;
            DateOfBirth = DOB;
            Age = Ag;
            Email = Eml;
            Password = Pd;
            EmpId = EI;
            Department = dpt;
            Title = ttl;
            Reportees = rpts;
            TotalExp = ttlExp;
            // Console.WriteLine("Parameterised constructor is called here");
        }

        public Manager()
        {

        }
        public void ReporteesInfo()
        {
            List<Reportees> list = new List<Reportees>();
            list.Add(new Reportees
            {
                ReporteeName = "revanth",
                ReporteeGender = "male",
                ReporteeEmpId = "123"



            });
            list.Add(new Reportees
            {
                ReporteeName = "bhavana",
                ReporteeGender = "female",
                ReporteeEmpId = "456"
            });
            list.Add(new Reportees
            {
                ReporteeName = "imran",
                ReporteeGender = "male",
                ReporteeEmpId = "789"
            });
            foreach (var a in list)
            {
                Console.WriteLine("ReporteeName = {0}, ReporteeGender = {1}, ReporteeId = {2}", a.ReporteeName, a.ReporteeGender, a.ReporteeEmpId);
            }

        }

        public void ddisplay()
        {

            Console.WriteLine("Employee and Manager Details ");
            Display();
            ReporteesInfo();
            Console.WriteLine("Department=" + Department);
            Console.WriteLine("Title=" + Title);
            Console.WriteLine("Reportees=" + Reportees);
            Console.WriteLine("Total years of experience=" + TotalExp);
        }
    }
}   


