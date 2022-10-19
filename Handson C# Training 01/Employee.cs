using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anu
{
     
         class Employee
         {
           public  string name = "Anusha";
           public  string gender = "Female";
           public int dob = 11-07-2000;
           public int age =22;
           public string email = "abcde@gmail.com";
           public string password ="hard";
           public int empid;

            
            public int age1
            {
                get { return age; }
            }
            public string password1
            {
                set { password = value; }
            }
          public Employee()
          {

        
          }
            public Employee(string name, string gender, int dob, int age, string email,string password, int empid)
            {
                this.name = name;
                this.gender = gender;
                this.dob = dob;
                this.age = age;
                this.email = email;
                this.empid = empid;
            }
            public void  EmployeeDisplays()
            {
                Console.WriteLine("Employee Details:");
                Console.WriteLine("\tName :" + name);
                Console.WriteLine("\tGender :" + gender);
                Console.WriteLine("\tDob :" + dob);
                Console.WriteLine("\tage :" + age);
                Console.WriteLine("\temail :" + email);
                Console.WriteLine("\tpassword :" + password);
                Console.WriteLine("\tempid :" + empid);

            }
        }
}
