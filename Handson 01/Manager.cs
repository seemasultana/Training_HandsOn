using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Codetest
{

	class Manager : Employee
	{
		public string Department = " Engineering";
		public string Title = "Associate Engineer";
		public int Reportees = 30;
		public int TotalExp = 10;


		piblic Manager()
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

		public void Display()
		{
			Console.WriteLine("Manager Detais ");
			Console.WriteLine("Department = " + Department);
			Console.WriteLine("Title = " + Title);
			Console.WriteLine("Reportees = " + Reportees);
			Console.WriteLine("TotalExp = " + ToalExp);
		}

		 
	}
}


	
	

