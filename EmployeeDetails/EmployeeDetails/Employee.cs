using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeDetails
{
    public class Employee
    {
        public int EmpId;
        public string Name;
        public string Gender;
        public string DateOfBirth;
        public int Age;
        public string Email;
        private int Password;
        
        public Employee()
        {

        }
        public Employee(int empId,string name, string gender, string dob, int age, string email)
        {
            EmpId = empId;
            Name = name;
            Gender = gender;
            DateOfBirth = dob;
            Age = age;
            Email = email;

        }
    }

    
}




