using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codetest
{
    class Employee
    {
        string name;
        string gender;
        int dob;
        int age;
        string email;
        string password;
        int empid;

        public Employee()
        {
            name = "Anusha";
            gender = "female";
            dob =  11-07-2000;
            age =  22;
            email = "kancharakuntlaanusha@gmail.com";
            password = "Anu";
            empid = 99018013;
        }
        public int age1
        {
            get { return age; }
        }
        public string password1
        {
            set { password = value; }
        }
        public Employee(string name, string gender, int dob, int age, string email,  int empid)
        {
            this.name = name;
            this.gender = gender;
            this.dob = dob;
            this.age = age;
            this.email = email;
            this.empid = empid;
        }
        public void printInfo()
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



        public static void Main(string[] args)
        {

          TechEmployees emp = new TechEmployees();
            Manager emp1 = new Manager();
            Console.WriteLine("Enter the EmpID = ");
            emp.Password = "Anu";
            int EmpID = (Console.ReadLine());
            if (EmpID == emp.EmpID)
            {
                emp.printInfo();
                emp.printInfo();
                emp1.printInfo();
            }
            else
            {
                Console.WriteLine("The EmpID is incorrect");
            }
            
            
        }





    }
    
    
        

    
} 
