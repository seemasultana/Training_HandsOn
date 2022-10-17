using System;

namespace ConstructorExample
{
    class ConstructorExample
    {
        static void Main(string[] args)
        {
            TechEmployees te = new TechEmployees();
            Manager m = new Manager();
            te.WriteOnlyPassword = "YAc@6302512457";
            te.Display();
            te.Showdetails();
            m.displaydetails();
            Console.Write("Enter the Employee ID to display the EmpCard Details: ");
            int Id=Convert.ToInt32(Console.ReadLine());
            if(Id == te.EmpId)
            {
                te.Display();
            }
            else
            {
                Console.WriteLine("Incorrect EmpId");
            }
        }
    }
}