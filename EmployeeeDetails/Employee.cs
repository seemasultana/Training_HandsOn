using System;

namespace EmployeeeDetails
{
    class Employee
    {
        public int EmpId;
        public string Name;
        public string Gender;
        public int Age;
        public string Email;
        public string Password;

        public Employee()//default Constructor
        {
        }

        public Employee(int empId, string name, string gender, string email, int age, string password)  //parametrized constructor
        {
            this.EmpId = empId;
            this.Name = name;
            this.Gender = gender;
            this.Email = email;
            this.Age = age;
            this.Password = password;
        }
        public void PrintEmployee()
        {
            Employee E1 = new Employee();
            E1.EmpId = Convert.ToInt32(Console.ReadLine());
            if (E1.EmpId == 1)
            {
                E1.Name = "Rajasutha";
                E1.Gender = "Female";
                E1.Email = "raji@harman.com";
                E1.Age = 22;
                E1.Password = "raji@123";
                Console.WriteLine("Name:" + E1.Name + "\nGender:" + E1.Gender + "\nEmail:" + E1.Email + "\nAge:" + E1.Age );

            }
            else if (E1.EmpId == 2)
            {
                E1.Name = "vijay";
                E1.Gender = "Male";
                E1.Email = "vijay@harman.com";
                E1.Age = 25;
                E1.Password = "vijay@123";
                Console.WriteLine("Name:" + E1.Name + "\nGender:" + E1.Gender + "\nEmail:" + E1.Email + "\nAge:" + E1.Age + "\nPassword:" + E1.Password);
            }
            else
            {
                Console.WriteLine("Enter valid employee_id:");
            }
        }
    }
}

