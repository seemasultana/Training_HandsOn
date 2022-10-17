using System;

public class TechEmployees:Employee

{
	public string Designation = "Associate Engineer";
	public string ReportingTo = "Zulquar Siddique";
	public string TotalExp = "7 months";
	public TechEmployees()
	{
		Console.WriteLine("Default constructor of TechEmployees class is called");
	}
	public TechEmployees(string Designation,string ReportingTo,string TotalExp)
	{
		this.Designation = Designation;
		this.ReportingTo = ReportingTo;
		this.TotalExp = TotalExp;
	}
	public void Showdetails()
	{
        Console.WriteLine("----TechEmployee details----");
        Console.WriteLine("Employee Designation: " + Designation);
        Console.WriteLine("Employee is Reporting To: " + ReportingTo);
        Console.WriteLine("Employee had an experience of: " + TotalExp);
    }
}
