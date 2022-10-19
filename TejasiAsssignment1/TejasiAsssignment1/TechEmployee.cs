using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TejasiAsssignment1
{
    public class TechEmployee:Employee
    {

        public string techEmployeeDesignation;
        public string techEmployeeReportingTo;
        public int techEmployeeTotalExp;
        public TechEmployee()
        {
           
        }
        

        public TechEmployee(string designation, string reportingTo, int totalExp, string name, string Gender, string DateOfBirth, string EmailId, string Password, int age, int Id)
        {
            techEmployeeDesignation = designation;
            techEmployeeReportingTo = reportingTo;
            techEmployeeTotalExp = totalExp;
            empName = name;
            empGender = Gender;
            empDateOfBirth = DateOfBirth;
            empEmailId = EmailId;
            empAge = age;
            empPassword = Password;
            empId = Id;

        }
        public void TechEmpinfo()
        {
            
            Console.WriteLine("Tech Employee Name is: " + " " + empName);
            Console.WriteLine("Tech Employee Gender is: " + " " + empGender);
            Console.WriteLine("Tech Employee DateofBirth is: " + " " + empDateOfBirth);
            Console.WriteLine("Tech Employee Email" + " " + empEmailId);
            Console.WriteLine("Tech Employee Password is" + empPassword);
            Console.WriteLine("Tech Employee age is : " + " " + empAge + "years");
            Console.WriteLine("Tech Employee id is: " + empId);
            Console.WriteLine("Tech Employee Designation is: " + " " + techEmployeeDesignation);
            Console.WriteLine("Tech Employee Reporting to : " + " " + techEmployeeReportingTo);
            Console.WriteLine("TechEmployee Experience is : " + " " + techEmployeeTotalExp + "years");
        }
    }
}
