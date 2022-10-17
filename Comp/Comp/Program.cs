using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;

namespace handson1
{
    public class Program
    {
        static public void Main(string[] args)
        {
            TechEmployee tech = new TechEmployee("arjun", "M", "24/10/2000", "arjun@gmail.com", "1234", 1, "product development", "Zulq", 0);
            Manager manager = new Manager("Zulq", "M", "xy", "zulq@gmail.com", "5678", 2, "HealthCare", "Manager", "x,y", 21);
           
            Console.WriteLine("Enter EmployeeId :");
            int Empid = Convert.ToInt32(Console.ReadLine());

            if (Empid == tech.EmployeeId)
            {
                tech.DisplayTechEmployee();
            }
            else if (Empid == manager.EmployeeId)
            {
                manager.DisplayManager();
            }
        }
    }
}