using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace company
{
    public class Employee
    { 
        public  Employee()
        {
            Console.WriteLine("The details of  Employee");
        }
        public string empname;
        public string empgender;
        public string empdateofbirth;
        public string empage;
        //public string Empage
        //{
        //    get { return empage; }
        //}
        public string empemail;
        public string emppassword;
        //public string Emppassword
        //{
        //    set { emppassword = value; }
        //}
        public string empid;

        public Employee(string name, string gender, string dateofbirth, string age, string email, string password, string id)
        {
           
           this.empname = name;
           Console.WriteLine("please enter employee name");
           this.empname= Console.ReadLine();

           this.empgender = gender;
           Console.WriteLine("please enter employee gender");
           this.empgender= Console.ReadLine();

           this.empdateofbirth = dateofbirth;
           Console.WriteLine("please enter employee dateofbirth");
           this.empdateofbirth = Console.ReadLine();

           this.empage = age;
           Console.WriteLine("please enter employee age");
           this.empage = Console.ReadLine();

            this.empemail = email;
            Console.WriteLine("please enter employee email");
            this.empemail = Console.ReadLine();

            this.emppassword = password;
            Console.WriteLine("please enter employee password");
            this.emppassword = Console.ReadLine();

            this.empid = id;
            Console.WriteLine("please enter employee id");
            this.empid = Console.ReadLine();

        }
    }
}
