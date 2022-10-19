using EmployeeConsoleApp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeConsoleApp
{
    class MainAssign
    {
        static void Main(string[] args)
        {
            var t = new TechEmployees("Lucky Ali", "Male", "21/06/1985", 61, "lucky.ali@tseries.com", "Lucky85", 27373728, "Singer", "TSeries", 8.8);



            //t.Passwordd = "ALILucky";
            //t.EmpDisplay();
            //t.TechEmpDisplay();

            var m = new Manager("TSeries", "Male", "19 Oct 1956", 89, "bhushan@tseries.com", "tseries200", 20000000, "MusicMaking", "Song Producer", "89", 9);


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
