using System;


namespace handson1
{
    public class Employee
    {
        public string Name;
        public string Gender;
        public string DateOfBirth;
        public string Email;
        public string password;
        public string Password;
        public int EmployeeId;
        public  int Age;
        public Employee()
        {
           
        }
        public Employee(string name, string gender, string dateOfBirth, string email, string password, int employeeId,int age)
        {
            Name = name;
            Gender = gender;
            DateOfBirth = dateOfBirth;
            Email = email;
            Password = password;
            Age = age;
            EmployeeId = employeeId;
           
        }
  

        public void DisplayEmployee()
        {
            Console.WriteLine("Name:" + Name);
            Console.WriteLine("Gender:" + Gender);
            Console.WriteLine("DateOfBirth:" + DateOfBirth);
            Console.WriteLine("Email:" + Email);
            Console.WriteLine("Age:" + Age);
            Console.WriteLine("EmployeeId:" + EmployeeId);
        }


    }
}