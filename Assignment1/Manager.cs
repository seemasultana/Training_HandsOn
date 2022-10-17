using System;

public class Manager:Employee
{
	public string Department = "Engineering";
	public string Title = "Associate Director";
	public int Reportees = 50;
	public int TotalExp = 10;
	public Manager()
	{
		Console.WriteLine("Default constructor of Manager class is called");
	}
    public Manager(string Department,string Title,int Reportees,int TotalExp)
    {
        this.Department = Department;
		this.Title = Title;
		this.Reportees = Reportees;
		this.TotalExp = TotalExp;
    }
	public void displaydetails()
	{
        Console.WriteLine("----Manager details----");
        Console.WriteLine("Department of Manager: " + Department);
        Console.WriteLine("Role of Manager: " + Title);
        Console.WriteLine("No. of Reportees: " + Reportees);
		Console.WriteLine("No. of years of Experience: "+TotalExp);
    }
}
