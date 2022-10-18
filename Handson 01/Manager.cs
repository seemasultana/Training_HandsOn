using company1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Company1
{


    public class Manager : Employee
    {
        public string department;
        public string title;
        public string reportees;
        public string totalexp;
        public Manager()
        {
            Console.WriteLine("Manager details");
        }
       
        public Manager(string name, string gender, string dateofbirth, string age, string email, string password, int id, string department, string title, string reportees, string totalexp) 
        {
            this.empname = name;
            this.empgender = gender;
            this.empdateofbirth = dateofbirth;
            this.empage = age;
            this.empemail = email;
            this.emppassword = password;
            this.empid = id;
            this.department = department;
            this.title = title;
            this.reportees = reportees;
            this.totalexp = totalexp;

        }
        public string Reportee()
        {
            List<ReporteesModelclass> reportees = new List<ReporteesModelclass>();
            var emp1 = new ReporteesModelclass()
            {
                empname = "Priyanka Gunda",
                empid = "99020148"
            };
            var emp2 = new ReporteesModelclass()
            {
                empname = "Bhavana",
                empid = "99018014"
            };
            var emp3 = new ReporteesModelclass()
            {
                empname="Pavani",
                empid="99029846"
            };
            reportees.Add(emp1);
            reportees.Add(emp2);
            reportees.Add(emp3);
            foreach (var emp in reportees)
            {
              Console.WriteLine("empname={0},empid={1}",emp.empname,emp.empid);
            }
            return Convert.ToString(reportees);

        }

        public void ManagerDisplayEmployee()
        {
            Console.WriteLine("Display Manager Details:");
            DisplayEmployee();
            Console.WriteLine("Department: " + department);
            Console.WriteLine("Title: " + title);
            Console.WriteLine("Reportees:"  );
            Reportee();
            Console.WriteLine("Total experience:"+ totalexp);

        }
    }
}



