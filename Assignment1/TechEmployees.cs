using System;

namespace ConstructorExample
{
	public class TechEmployees : Employee

	{
		public string Designation ;
		public string ReportingTo ;
		public string TotalExp;
		public TechEmployees(string Nm,string gender, string DoB, int Age, string email, string pwd, int empId,string designation, string reportingTo, string totalExp)
		{
			Name = Nm;
			Gender = gender;
			DateOfBirth = DoB;
			Email=email;
			Password = pwd;
			EmpId = empId;
			Designation = designation;
			ReportingTo = reportingTo;
			TotalExp = totalExp;
		}
		public void Showdetails()
		{

			Console.WriteLine("----TechEmployee details----");
			Display();
			Console.WriteLine("Employee Designation: " + Designation);
			Console.WriteLine("Employee is Reporting To: " + ReportingTo);
			Console.WriteLine("Employee had an experience of: " + TotalExp);
		}
	}
}
