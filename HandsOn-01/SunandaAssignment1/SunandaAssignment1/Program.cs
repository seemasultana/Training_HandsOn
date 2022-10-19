using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SunandaAssignment1
{
    class program
    {


        public static void Main(string[] args)
        {
            Employee employee = new Employee("Sunanada", "Female", "01-3-2000", 21, "abc@gmail.com", "efef4", 99018000); ;
            TechEmployees emp = new TechEmployees("vikas", "male", "2-4-2010", 13, "viki@gmail.com", "fgrg", 99012, "Software Engineer", "Manager", 5);
            Manager emp1 = new Manager("revanth", "male", "25-7-20001", 20, "revanth@gmail.com", "asdf", 990180, "Enginnering", "Associate Engineer", 50, 10);
            Console.WriteLine("Enter the Employee Id : ");


            int empid = Convert.ToInt32(Console.ReadLine());
            if (empid == employee.EmpId)
            {
                employee.Display();

            }
            else if (empid == emp.EmpId)
            {
                emp.display();
            }
            else
            {
                emp1.ddisplay();

            }
            Console.WriteLine("All the information is displayed");
            Console.ReadKey();
        }
    }
}







