using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    internal class Program
    {
        static void Main(string[]args)

        {
                
            TechEmployees o1 = new TechEmployees("ram", "male","8/03/2000", 23, "ram@gmail.com", "ram123", 990, "associate engineer", "rishi", 2);
            TechEmployees o3 = new TechEmployees("sita", "female", "06/03/2000", 24, "sita@gmail.com", "sita234", 992, "Graduate Trainee", "Rishi", 2);
            Manager o2 = new Manager("rishi", "male", "9/03/1995", 28, "rishi59@yahoo.com", "rishi#213", 991, "HR department", "Associate HR", 7, "ram");

            Console.WriteLine("WELCOME TO HARMAN");
            Console.WriteLine("ARE YOU AN EXISTING EMPLOYEE");
            string ans = Console.ReadLine();
            if (ans == "yes")
            {
                int i = 0;
                do
                {

                    Console.WriteLine("ENTER YOUR EMPLOYEE ID");
                    int in1 = Convert.ToInt32(Console.ReadLine());
                    if (in1 == o1.EmpId)
                    {
                        o1.displaydetails();
                        
                    }
                    else if (in1 == o2.EmpId)
                    {
                        o2.displaydetails();
                        
                    }
                    else if(in1 == o3.EmpId)
                    {
                        o3.displaydetails();
                    }

                    else
                    {
                        Console.WriteLine("INCORRECT EMP-ID PLEASE RETRY!!!!!!!");
                        
                    }
                    i++;
                } while (i < 2);


            }
            






        }
        
    }
}
