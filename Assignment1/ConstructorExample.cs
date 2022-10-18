using System;

namespace ConstructorExample
{
    class ConstructorExample
    {
        static void Main(string[] args)
        {
            TechEmployees te = new TechEmployees("Aparna","Female","11/06/2001",21,"Aparna.Yellina@harman.com","aaaa",990,"Associate Engineer","Zulquar","7 Months");
            Manager m = new Manager("zulquar", "male", "9/03/1995", 38, "Zulquar.siddique@harman.com", "bbbb", 991, "Engineering", "Associate Director", 10);
            int c = 0;
            do
            {
                Console.Write("Enter the Employee ID to display the EmpCard Details: ");
                int Id = Convert.ToInt32(Console.ReadLine());
                if (Id == te.EmpId)
                {
                    te.Showdetails();
                }
                else if (Id == m.EmpId)
                {
                    m.displaydetails();
                   
                }
                else
                {

                    Console.WriteLine("Incorrect details");
                }
                c++;
            } while (c < 3);
        }
    }
}