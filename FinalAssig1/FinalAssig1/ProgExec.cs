using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalAssig1
{
    class ProgExec
    {
        static void Main(string[] args)
        {
            TechEmployees t = new TechEmployees("Bhoomika Yadwad", "Female", "21/06/2000", 22, "bhoomika.yadwad@harman.com", "harman21", 99021719, "Associate Engineer", "Zulquar", 7.8);



            //t.Passwordd = "BYadwad";
            //t.EmpDisplay();
            //t.TechEmpDisplay();

            Manager m = new Manager("Zulquar Siddiquee", "Male", "14 December 1988", 40, "zulq@harman.com", "zulq123", 99021717, "DTS", "Associate Director", "45", 9);


            //m.ManagerDisplay();

            Console.WriteLine("\nEnter the Employee ID (EmpId) to display the details: ");
            int Id = Convert.ToInt32(Console.ReadLine());
            if (Id == t.EmpId)
            {
                t.TechEmpDisplay();

            }
            else
            {
                m.ManagerDisplay();
            }

        }
    }
}
