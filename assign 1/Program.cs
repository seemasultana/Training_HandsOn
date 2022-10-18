using employeees;
class Program
{
    static void Main(string[] args)
    {
        TechEmployee emp = new TechEmployee("Employee", 'M', "1/1/2001", 21,
            "employee123@company.com", "passwd", 990,
            "SDE", "Manager", 1);
        Manager mgr = new Manager("Manager", 'F', "2/2/2000", 22,
            "manager234@company.com", "passwd01", 991,
            "Software Engineering", "Tech Lead", 2);
        
        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine("enter the employee id:");
            int empid = Convert.ToInt32(Console.ReadLine());
            if (empid == emp.EmpId)
            {
                emp.TechEmpDisp();

            }
            else if (empid == mgr.EmpId)
            {
                mgr.ManagerDisp();
            }
            else
            {
                Console.WriteLine("invalid!");

            }
        }
    }

}
