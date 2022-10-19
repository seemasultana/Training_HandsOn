using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            TechEmployees TE = new TechEmployees();
            Manager m = new Manager();
            TE.WritePassword = "Anu@123456";
           
            Console.Write("Enter the Employee ID : ");
            int Id = Convert.ToInt32(Console.ReadLine());
            if (Id == TE.EmpId)
            {
                TE.Display();
                TE.Showdetails();
                m.displaydetails();
            }
            else
            {
                Console.WriteLine("Incorrect Employee Id");
            }
        }
    }
}