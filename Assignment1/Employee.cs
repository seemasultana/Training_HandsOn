using System;

public class Employee
{
	public string Name="Aparna";
	public string Gender="Female";
	public string DateOfBirth="11/06/2001";
	public readonly int age=21;
	public string Email="Aparna.Yellina@harman.com";
	public string Password;
	public int EmpId=99017997;
	public int ReadOnlyAge
	{
		get { return age; }
	}

	public string WriteOnlyPassword
	{
		set { Password = value; }
	}
	public Employee()
	{
        Console.WriteLine("Default constructor of Employee class is called ");
	}
	public Employee(string Name, string Gender, string DateOfBirth, int age, string Email, int EmpId)
	{
		this.Name = Name;
		this.Gender = Gender;
		this.DateOfBirth = DateOfBirth;
		this.age = age;
		this.Email = Email;
		this.EmpId = EmpId;	
	}
	public void Display()
    {
        Console.WriteLine("----Employee details----");
        Console.WriteLine("Employee Name: "+Name);
		Console.WriteLine("Employee Gender: " + Gender);
		Console.WriteLine("Employee DOB: " + DateOfBirth);
		Console.WriteLine("Employee Age: " + age);
		Console.WriteLine("Employee EMailID: " +Email );
		Console.WriteLine("Password: " + Password);
		Console.WriteLine("Employee ID: " + EmpId);
	}
}
