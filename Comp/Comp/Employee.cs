using System;


namespace handson1
{
    public class Employee
    {
        public string Name;
        public string Gender;
        public string DateOfBirth;
        public readonly int Age;
        public string Email;
        public string password;
        public string Password { set { password = value; } }
        public int EmployeeId;
    public Employee()
        {
            Console.WriteLine("This is a constructor for Employee class");
           
        }
        public Employee(string name, string gender, string dateOfBirth, int age, string email, string password, int employeeId)
        {
            this.Name = name;
            this.Gender = gender;
            this.DateOfBirth = dateOfBirth;
            this.Email = email;
            this.Password = password;
            this.EmployeeId = employeeId;
            this.Age = age;
        }
        public void InsertEmployee()
        {
            Console.WriteLine("Enter The Name: ");
            Name = Console.ReadLine();
            Console.WriteLine("Enter The Gender: ");
            Gender = Console.ReadLine();
            Console.WriteLine("Enter The DateOfBirth: ");
            DateOfBirth = Console.ReadLine();
            Console.WriteLine("Enter The Email: ");
            Email = Console.ReadLine();
            Console.WriteLine("Enter The Password: ");
            Password = Console.ReadLine();
            Console.WriteLine("Enter The EmployeeId: ");
            EmployeeId = Convert.ToInt32(Console.ReadLine());
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