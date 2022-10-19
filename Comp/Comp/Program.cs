using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;

namespace handson1
{
    public class Program
    {
        static public void Main(string[] args)
        {
            Employee  obj1 = new Employee("abc","m","xy/x/xyxy","arj.mail.com","12345",0,20);
            TechEmployee obj2 = new TechEmployee("arjun", "M", "24/10/2000", "arjun@gmail.com",21,1, "product development", "Zulq", 0);
            Manager obj3 = new Manager("Zulq", "M", "x/x/xxxx", "zulq@gmail.com", 22,"5678",2, "HealthCare", "Manager", "abc-Employee id is 0,arjun-Employee id is 1", 21);
           
            Console.WriteLine("Enter EmployeeId :");
            int Empid = Convert.ToInt32(Console.ReadLine());

            if(Empid == obj1.EmployeeId)
            {
                obj1.DisplayEmployee();
            }
            else if (Empid == obj2.EmployeeId)
            {
                obj2.DisplayTechEmployee();
            }
            else if (Empid == obj3.EmployeeId)
            {
                obj3.DisplayManager();
            }
            else
            {
                Console.WriteLine("Enter valid Employee Id");
            }

        }
    }
}