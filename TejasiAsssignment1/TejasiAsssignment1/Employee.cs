using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TejasiAsssignment1
{
    
    public class Employee
    {
        public string empName;
        public string empGender;
        public string empDateOfBirth;
        public string empEmailId ;
        public string empPassword;
        public int empAge;
        
        public int empId;
        public int AgeofEmployee
        {
            get
            {
                return empAge;
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
           
        }
        public Employee(string name, string Gender, string DateOfBirth, string EmailId, string Password, int age, int Id)
        {
            empName = name;
            empGender = Gender;
            empDateOfBirth = DateOfBirth;
            empEmailId = EmailId;
            empPassword = Password;
            empAge = age;
           
            empId = Id;
            
        }
        public void Empinfo()

        {
            Console.WriteLine("The Employee Name is: " + " " + empName);
            Console.WriteLine("Employee Gender is: " + " " + empGender);
            Console.WriteLine("Employee DateofBirth is: " + " " + empDateOfBirth);
            Console.WriteLine("Employee Email" + " " + empEmailId);
            Console.WriteLine("Employee Password is" + empPassword);
            Console.WriteLine("Employee age is : " + " " + empAge + "years");
            Console.WriteLine("Employee id is: " + empId);

        }
    }
}

