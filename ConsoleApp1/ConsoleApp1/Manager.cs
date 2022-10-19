using System;

namespace ConsoleApp1
{
    public class Manager : Employee
    {
        public string Department = "Engineering";
        public string Title = "Associate Director";
        public int Reportees = 50;
        public int TotalExp = 10;
        public Manager()
        {
            Console.WriteLine("Default constructor called");
        }
        public Manager(string Department, string Title, int Reportees, int TotalExp)
        {
            this.Department = Department;
            this.Title = Title;
            this.Reportees = Reportees;
            this.TotalExp = TotalExp;
        }

        public string Reportee()
        {
            List<Reportees> R = new List<Reportees>();



            var a = new Reportees()
            {
                name = "Aditya",
                empid = "1234",
                Role = "Assoc. Engineer"



            };
            var b = new Reportees()
            {
                name = "Harsh",
                empid = "1235",
                Role = "Assoc. Engineer"
            };
            var c = new Reportees()
            {
                name = "Honey",
                empid = "1236",
                Role = "Assoc. Engineer"
            };
            R.Add(a);
            R.Add(b);
            R.Add(c);



            foreach (var d in R)
            {
                Console.WriteLine("name:{0},empid:{1},role:{2}", d.name, d.empid, d.Role);
            }
            return Convert.ToString(R);
        }
        public void displaydetails()
        {

            Console.WriteLine("Department of Manager: " + Department);
            Console.WriteLine("Title of Manager: " + Title);
            Console.WriteLine("No. of Reportees: " + Reportees);
            Console.WriteLine("Reportees: ");
            Reportee();
            Console.WriteLine("Manager's years of Experience: " + TotalExp);
        }
    }
}