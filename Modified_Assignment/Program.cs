using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice1
{

    public class Program
    {
        static void Main(string[] args)
        {
            TechEmployees emp = new TechEmployees("Anindita Gogoi", "Female",
            "27-06-2000", 23, "Anindita.Gogoi@harman.com", 99021720, "1234",
            "Associate Engineer", "Zulquar Siddiquee", 1);
            Manager emp1 = new Manager("Zulquar Siddiquee", "Male", "24-06-1960",
                62, "Zulquar.Siddiquee@harman.com", 990, "5678", "Engineering", "Associate Director", 10);

            for (int i = 0; i < 4; i++)
            {
                Console.Write("Enter the Employee Id = ");

                int empid = Convert.ToInt32(Console.ReadLine());
                if (empid == emp.EmpID)
                {
                    emp.TechDisplay();
                }
                else if (empid == emp1.EmpID)
                {

                    emp1.ManDisplay();
                }
                else
                {
                    Console.WriteLine("The Employee ID is incorrect");
                }
            }

        }
    }



}
