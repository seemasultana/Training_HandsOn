using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TejasiAssignment1
{
    internal class TechEmployee:Employee
    {

        public string techEmployeeDesignation ;
        public string techEmployeeReportingTo ;
        public int techEmployeeTotalExp ;
        public TechEmployee()
        {
            Console.WriteLine("Default Constructor of TechEmployee child class called");
        }
        public override void Empinfo(string name, string empGender, string empDateOfBirth, string empEmailId, int age, string empPassword, int empId)//method overriding from employee class.
        {
            base.Empinfo(name, empGender, empDateOfBirth, empEmailId, age, empPassword, empId);
        }

        public TechEmployee(string designation, string reportingTo, int totalExp)
        {
            this.techEmployeeDesignation = designation;
            this.techEmployeeReportingTo = reportingTo;
            this.techEmployeeTotalExp = totalExp;
        }
        public void TechEmpinfo(string techEmployeeDesignation, string techEmployeeReportingTo, int techEmployeeTotalExp)
        {
            Console.WriteLine("TechEmployee Designation is: " + " " + techEmployeeDesignation);
            Console.WriteLine("TechEmployee Reporting to : " + " " + techEmployeeReportingTo);
            Console.WriteLine("TechEmployee Experience is : " + " " + techEmployeeTotalExp + "years");
        }
    }
}

