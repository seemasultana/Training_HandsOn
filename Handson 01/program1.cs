using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace company
{
    class program1
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee("Employee name:", "gender : ", "dateofbirth : ", "Empolyee Age:", "email : ", "password : ", "employee id:");
            TechEmployee techEmployee = new TechEmployee("Designation of employee: ", "ReportingManager: ", "Totalexp of employee: ");
            Managerdetails managerdetails = new Managerdetails("department of manager: ", "title of manager: ", "reportees:", "totalexp of manager:");
            Console.WriteLine("Employee name:"+ employee.empname);
            Console.WriteLine("gender :"+ employee.empgender);
            Console.WriteLine("dateofbirth : "+employee.empdateofbirth);
            Console.WriteLine("Empolyee Age:"+employee.empage);
            Console.WriteLine("email : "+employee.empemail);
            Console.WriteLine("employee id:"+employee.empid);



           // TechEmployee techEmployee = new TechEmployee("Designation of employee: ", "ReportingManager: ", "Totalexp of employee: ");
            Employee techEmployee1 = employee;
            Console.WriteLine("##########employee and their role details############");
            Console.WriteLine("Employee name:"+techEmployee1.empname);
            Console.WriteLine("gender :"+techEmployee1.empgender);
            Console.WriteLine("dateofbirth:"+ techEmployee1.empdateofbirth);
            Console.WriteLine("Empolyee Age:"+techEmployee1.empage);
            Console.WriteLine("email : "+techEmployee1.empemail);
            Console.WriteLine("employee id:"+techEmployee1.empid);
            Console.WriteLine("Designation of employee: "+techEmployee.techdesignation);
            Console.WriteLine("ReportingManager: "+techEmployee.techreportingmanager);
            Console.WriteLine("Totalexp of employee: "+techEmployee.techtotalexp);




           // Managerdetails managerdetails = new Managerdetails("department of manager: ", "title of manager: ", "reportees:", "totalexp of manager:");
            Employee managerdetails1 = employee;
            Console.WriteLine("##########employee and his/her manager details##########");
            Console.WriteLine("Employee name:" + managerdetails1.empname);
            Console.WriteLine("gender :"+managerdetails1.empgender);
            Console.WriteLine("dateofbirth:"+managerdetails1.empdateofbirth);
            Console.WriteLine("Empolyee Age:"+managerdetails1.empage);
            Console.WriteLine("email : "+managerdetails1.empemail);
            Console.WriteLine("employee id:"+managerdetails1.empid);
            Console.WriteLine("department of manager: "+managerdetails.department);
            Console.WriteLine("title of manager: "+managerdetails.title);
            Console.WriteLine("reportees:"+managerdetails.reportees);
            Console.WriteLine("totalexp of manager:"+managerdetails.totalexp);
        }              
    }
}

