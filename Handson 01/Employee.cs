using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace company1
{
    public class Employee
    {
        public Employee()
        {
            Console.WriteLine("This Default Constructor Of Employee Class");
        }
        public string empname;
        public string empgender;
        public string empdateofbirth;
        public string empage;
        public string Empage
        {
            get { return empage; }
        }
        public string empemail;
        public string emppassword;

        public string Emppassword
        {
            set { emppassword = value; }
        }
        public int empid;

        public Employee(string name, string gender, string dateofbirth, string age, string email, string password, int id)
        {

            this.empname = name;
            this.empgender = gender;
            this.empdateofbirth = dateofbirth;
            this.empage = age;
            this.empemail = email;
            this.emppassword = password;
            this.empid = id;


        }
        public void DisplayEmployee()
        {
            Console.WriteLine("Name:"+ empname);
            Console.WriteLine("Gender:" + empgender);
            Console.WriteLine("DateOfBirth:" + empdateofbirth);
            Console.WriteLine("Age:"+ empage);
            Console.WriteLine("Email:" + empemail);
            Console.WriteLine("Employee id:" + empid);
        }
    }
}
