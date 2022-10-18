using Company1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace company1
{

    public class TechEmployee : Employee
    {
        public string techdesignation;
        public string techreportingmanager;
        public string techtotalexp;
        public TechEmployee()
        {
            Console.WriteLine("employee role details");
        }
        public TechEmployee(string name, string gender, string dateofbirth, string age, string email, string password, int id, string designation, string reportingmanager, string totalexp)
        {
            this.empname = name;
            this.empgender = gender;
            this.empdateofbirth = dateofbirth;
            this.empage = age;
            this.empemail = email;
            this.emppassword = password;
            this.empid = id;
            this.techdesignation = designation;
            this.techreportingmanager = reportingmanager;
            this.techtotalexp = totalexp;

        }
        public void TechDisplayEmployee()
        {
            Console.WriteLine("Display Techical Employee Details:");
            DisplayEmployee();
            Console.WriteLine("Designation: " + techdesignation);
            Console.WriteLine("ReportingManager: " + techreportingmanager);
            Console.WriteLine("TotalExp:" + techtotalexp);
           
        }
    }
}



