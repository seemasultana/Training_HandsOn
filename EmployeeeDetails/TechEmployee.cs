using System;

namespace EmployeeeDetails
{
    class TechEmployee:Employee
    {
        public string Designation;
        public string ReportingTo;
        public int TotalExp;

        public TechEmployee()
        {
        }

        public TechEmployee(string designation, string reportingTo, int totalExp)
        {
            this.Designation = designation;
            this.ReportingTo = reportingTo;
            this.TotalExp = totalExp;
        }
        public void PrintTechEmployee()
        {
            TechEmployee E2 = new TechEmployee();
            if (E2.EmpId ==1)
            {
                E2.Designation = "Associate Engineer";
                E2.ReportingTo = "Zulquar";
                E2.TotalExp = 3;
                Console.WriteLine("Designation:" + E2.Designation + "\nReportingTo:" + E2.ReportingTo + "\nTotalExp:" + E2.TotalExp);

            }
            else if (E2.EmpId == 2)
            {
                E2.Designation = "Senoir developer";
                E2.ReportingTo = "Zulquar";
                E2.TotalExp = 5;
                Console.WriteLine("Designation:" + E2.Designation + "\nReportingTo:" + E2.ReportingTo + "\nTotalExp:" + E2.TotalExp);

            }
            else
            {
                Console.WriteLine("Enter valid employee_id");
            }
        }
    }
}
