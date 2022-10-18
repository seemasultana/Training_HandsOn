using System;

namespace EmpDetails
{
    class TechEmployee:Employee
    {
        public string Designation;
        public string ReportingTo;
        public int TotalExp;

        public TechEmployee()
        {
        }

        public TechEmployee(int empId,string name, string gender, string dateOfBirth, int age, string email, string password, string designation, string reportingTo, int totalExp)
        {
            EmpId = empId;
            Name = name;
            Gender = gender;
            DateOfBirth = dateOfBirth;
            Age = age;
            Email = email;
            Password = password;
            Designation = designation;
            ReportingTo = reportingTo;
            TotalExp = totalExp;

        }
        public void PrintTechEmployee()
        {
            Console.WriteLine("Enter TechEmployee Details:");
            PrintEmployee();
            Console.WriteLine("Designation:"+Designation+"\nReportingTo:"+ReportingTo+"\nTotalExp:"+TotalExp);
        }
    }
}
