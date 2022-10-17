using System;

namespace EmployeeeDetails
{
    class Manager : Employee
    {
        public string Department;
        public string Title;
        public int Reportees;
        public int TotalExp;
        public Manager()
        {
        }

        public Manager(string department, string title, int reportees, int totalExp)
        {
            this.Department = department;
            this.Title = title;
            this.Reportees = reportees;
            this.TotalExp = totalExp;
        }
        public void PrintManager()
        {
            Manager E3 = new Manager();
            E3.EmpId = Convert.ToInt32(Console.ReadLine());
            if (E3.EmpId == 1)
            {
                E3.Department = "Engineering";
                E3.Title = "Director";
                E3.Reportees = 50;
                E3.TotalExp = 3;
                Console.WriteLine("Department:" + E3.Department + "\nTitle:" + E3.Title + "\nReportees:" + E3.Reportees + "\nTotalExp:" + E3.TotalExp);

            }
            else if (E3.EmpId == 2)
            {
                E3.Department = "Engineering";
                E3.Title = "Director";
                E3.Reportees = 25;
                E3.TotalExp = 9;
                Console.WriteLine("Department:" + E3.Department + "\nTitle:" + E3.Title + "\nReportees:" + E3.Reportees + "\nTotalExp:" + E3.TotalExp);

            }
            else
            {
                Console.WriteLine("Enter valid employee_id");
            }
        }

    }
}
