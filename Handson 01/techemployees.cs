using System;

namespace Codetest
{

	class TechEmployees : TechEmployees
	{
		public string Designation = "Associate Engineer";
		public string ReportingTo = "Zulquer Siddique";
		public int TotalExp = 6 Months;


	    public TechEmployees()
		{
			Console.WriteLine("Default Constructor is called here");
		}

		public TechEmployees(string designation, string RepotingTo, int TotalExp)
		{
			this.Designation = designation;
			this.ReportingToTo = ReportingTo;
			this.TotalExp = TotalExp;
			Console.WriteLine("Parameterised Constructor is called here");

		}


		public void Display()
		{
			Console.WriteLine("TechEmployees Details ");
			Console.WriteLine("Designation " + designation);
			Console.WriteLine("RepotingTo = " + ReportingTo);
			Console.WriteLine("TotalExp = " + TotalExp);
		}







	}
}

	

