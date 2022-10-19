using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anusha
{

    public class program
    {

      

       public static void Main(string[] args)
       {

          TechEmployees emp = new TechEmployees();
          Manager emp1 = new Manager();
          Console.WriteLine("Enter the EmpID = ");
        
          int EmpID = Convert.ToInt32(Console.ReadLine());
          if (EmpID == 99018013)
          {
                emp.printInfo();
                emp.display();
                emp1.Display();
          }
            else
            {
                Console.WriteLine("The EmpID is incorrect");
            }



        }
        


    }






}
