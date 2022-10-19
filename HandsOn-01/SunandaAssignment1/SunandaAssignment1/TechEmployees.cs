using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SunandaAssignment1
{

    class TechEmployees : Employee
    {
        public string Designation = "Associate Engineer";
        public string ReportingTo = "Zulquar Siddique";
        public int TotalExp = 0;



        public TechEmployees(string Nm, string Gd, string DOB, int Ag, string Eml, string Pd, int EI, string Dsgn, string RTo, int TExp)
        {
            Name = Nm;
            Gender = Gd;
            DateOfBirth = DOB;
            Age = Ag;
            Email = Eml;
            Password = Pd;
            EmpId = EI;
            Designation = Dsgn;
            ReportingTo = RTo;
            TotalExp = TExp;
            // Console.WriteLine("Parameterised constructor is called here");
        }

        public void display()
        {

            Console.WriteLine(" Employee Details ");
            Display();
            Console.WriteLine("Designation=" + Designation);
            Console.WriteLine("Reportees=" + ReportingTo);
            Console.WriteLine("Total experience=" + TotalExp);
        }

    }
}


