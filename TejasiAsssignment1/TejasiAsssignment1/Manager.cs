using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TejasiAsssignment1
{
    public class Manager:Employee
    {
        public string Department;
        public string Title;
        public int Reportees;
        public int TotalExperience;

        

        public Manager()
        {
            
        }
        public Manager(string department, string title, int reportees, int totalExperience, string name, string Gender, string DateOfBirth, string EmailId, string Password, int age, int Id)
        {
            Department = department;
            Title = title;
            Reportees = reportees;
            TotalExperience = totalExperience;
            empName = name;
            empGender = Gender;
            empDateOfBirth = DateOfBirth;
            empEmailId = EmailId;
            empAge = age;
            empPassword = Password;
            empId = Id;

        }
        public void ReporteesInfo()
        {
            List<ReporteesModelClass> Reportees = new List<ReporteesModelClass>();
            Reportees.Add(new ReporteesModelClass
            {
                ReporteeId = "123",
                ReporteeName = "anki",
                ReporteeEmailId = "anki@gmail.com"


            });
            Reportees.Add(new ReporteesModelClass
            {
                ReporteeId = "124",
                ReporteeName = "ani",
                ReporteeEmailId = "ani@gmail.com"
            });
            Reportees.Add(new ReporteesModelClass
            {
                ReporteeId = "125",
                ReporteeName = "sudha",
                ReporteeEmailId = "sudha@gmail.com"

            });
            Reportees.Add(new ReporteesModelClass
            {
                ReporteeId = "126",
                ReporteeName = "sunanda",
                ReporteeEmailId = "sunanda@gmail.com"

            });
            foreach (var d in Reportees)
            {
                Console.WriteLine("ReporteeId = {0}, ReporteeNmae = {1} ,ReporteeEmailId = {2}", d.ReporteeId, d.ReporteeName, d.ReporteeEmailId);
            }







        }
        public void Managerinfo()
        {
            Console.WriteLine("Manager  Name is: " + " " + empName);
            Console.WriteLine("Manager Gender is: " + " " + empGender);
            Console.WriteLine("Manager  DateofBirth is: " + " " + empDateOfBirth);
            Console.WriteLine("Manager  Email" + " " + empEmailId);
            Console.WriteLine("Manager Password is" + empPassword);
           Console.WriteLine("Manager age is : " + " " + empAge + "years");
            Console.WriteLine("Manager  id is: " + empId);
            Console.WriteLine("Manager Department is: " + " " + Department);
            Console.WriteLine("The title is " + " " + Title);
            Console.WriteLine("The number of Reportees are : " + " " + Reportees);
            ReporteesInfo();
            Console.WriteLine("The total Experience he has of:" + " " + TotalExperience + " " + "years");
        }

    }
}
