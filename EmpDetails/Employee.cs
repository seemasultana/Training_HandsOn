using System;

namespace EmpDetails
{
    class Employee
    {
        public int EmpId;
        public string Name;
        public string Gender;
        public string DateOfBirth;
        public int Age;
        public string Email;
        public string Password;

        public Employee()
        {
        }

        public  Employee(int empId, string name, string gender, string dateOfBirth, int age, string email, string password)
        {
            EmpId = empId;
            Name = name;
            Gender = gender;
            DateOfBirth = dateOfBirth;
            Age = age;
            Email = email;
            Password = password;
        }
        public  void  PrintEmployee()
        {
            Console.WriteLine("Name:" + Name + "\nGender:" + Gender + "\nDateOfBirth:" + DateOfBirth + "\nAge:" + Age + "\nEmail:" + Email + "\nPassword:" + Password);
        }
    }
}
