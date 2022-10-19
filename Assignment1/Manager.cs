using System;
using System.Collections.Generic;

namespace ConstructorExample
{

	public class Manager : Employee
    {
		public string Department;
		public string Title;
		public string Reportees ;
		public int TotalExp;
		public Manager(string Nm, string gender, string DoB, int Age, string email, string pwd, int empId, string department, string title,  int totalExp)
		{
            Name = Nm;
            Gender = gender;
            DateOfBirth = DoB;
            Email = email;
            Password = pwd;
            EmpId = empId;
            Department = department;
			Title = title;
		    TotalExp = totalExp;
		}
        public string Reportee()
        {
            List<ReporteeModelclass> Reporteelist = new List<ReporteeModelclass>();

            var a = new ReporteeModelclass()
            {
                name = "Aparna",
                empid = "9911",
                role = "Assoc. Engineer"

            };
            var b = new ReporteeModelclass()
            {
                name = "Priyanka",
                empid = "9912",
                role = "Assoc. Engineer"
            };
            var c = new ReporteeModelclass()
            {
                name = "Arjun",
                empid = "9913",
                role = "Assoc. Engineer"
            };
            Reporteelist.Add(a);
            Reporteelist.Add(b);
            Reporteelist.Add(c);

            foreach (var d in Reporteelist)
            {
                Console.WriteLine("name:{0},empid:{1},role:{2}",d.name,d.empid,d.role);
            }
            return Convert.ToString(Reporteelist);  
        }
        public void displaydetails()
		{
			Console.WriteLine("----Manager details----");
			Display();
			Console.WriteLine("Department of Manager: " + Department);
			Console.WriteLine("Role of Manager: " + Title);
            Console.WriteLine("Reportess: ");
            Reportee();
			Console.WriteLine("No. of years of Experience: " + TotalExp);
		}
	}
}
