namespace EmployeeConsoleApp
{
    class MainAssign
    {
        static void Main(string[] args)
        {
            var tec = new TechEmployees();
            tec.Password1 = "o sanam";
            tec.EmpDisplay();
            tec.TechEmpDisplay();

            var man = new Manager();
            man.ManagerDisplay();

            Console.WriteLine("\n Enter the Employee ID (EmpId) for the details: ");
            int id = Convert.ToInt32(Console.ReadLine());
            if (id == tec.EmpId)
            {
                tec.EmpDisplay();
                tec.TechEmpDisplay();
                man.ManagerDisplay();
            }
            else
            {
                Console.WriteLine("Employee Id entered is not correct");
            }
        }
    }
}
