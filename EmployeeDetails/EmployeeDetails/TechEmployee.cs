using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeDetails
{
    public class TechEmployee: Employee
    {
        public string Designation;
        public string ReportingTo;
        public string TotalExperience;

        public TechEmployee()
        {

        }

        public TechEmployee(string designation, string reportingTo, string totalExperience)
        {
            Designation = designation;
            ReportingTo = reportingTo;
            TotalExperience = totalExperience;
        }

        
    }

   
}
