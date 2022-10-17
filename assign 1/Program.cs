// Main Program
using employeees;

class Program
{
    static void Main(string[] args)
    {
        // Creating Tech Employee Object and assigning values
        TechEmployee emp = new TechEmployee();
        emp.AcceptTechEmployee("Employee", 'M', "1/1/2001", 21,
            "employee123@company.com", "passwd", "empid01",
            "SDE", "Manager", 1);
        Console.WriteLine("Employee Details\n");
        emp.TechEmpDisp("empid01");

        Console.WriteLine("\n");

        // Create Manager Object and assigning values
        Manager mgr = new Manager();
        mgr.AcceptManager("Manager", 'F', "2/2/2000", 22,
            "manager234@company.com", "passwd01", "mgrid01",
            "Software Engineering", "Tech Lead", 8, 2);
        Console.WriteLine("Manager Details\n");
        mgr.ManagerDisp("mgrid01");

    }
}
