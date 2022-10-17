using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TejasiAssignment1
{
    internal class Employee
    {
        public string name;
        public string empGender;
        public string empDateOfBirth;
        public string empEmailId;
        public int age;
        public string empPassword;
        public int empId;
        public int AgeofEmployee
        {
            get
            {
                return age;
            }
        }
        public string PasswordOfEmployee
        {
            set
            {
                empPassword = value;
            }
        }

        public Employee()
        {
            Console.WriteLine("Default Constructor of Parent Class Employee Called");
        }
        public Employee(string name, string empGender, string empDateOfBirth, string empEmailId,string empPassword, int age , int empId)
        {
            this.name = name;
            this.empGender = empGender;
            this.empDateOfBirth = empDateOfBirth;
            this.empEmailId = empEmailId;
            this.age = age;
            this.empPassword = empPassword;
            this.empId = empId;
            PasswordOfEmployee = empPassword;
        }
        public virtual void Empinfo(string name, string empGender, string empDateOfBirth, string empEmailId, int age, string empPassword, int empId)

        {
            Console.WriteLine("The Employee Name is: " + " " + name);
            Console.WriteLine("Employee Gender is: " + " " + empGender);
            Console.WriteLine("Employee DateofBirth is: " + " " + empDateOfBirth);
            Console.WriteLine("Employee age is : " + " " + age + "years");
            Console.WriteLine("Employee Email" + " " + empEmailId);
            Console.WriteLine("Employee id is: " + empId);


        }
    }
}
