using oops1;

class program
{
    static void Main(string[] args)
    {
        int ch;
        do
        {
            Console.WriteLine("select any option");
            server obj = new server();
            obj.display();
            Console.WriteLine("click 0 to exit\n click 1 to deposit \n click 2 to withdraw");
            ch = Convert.ToInt32(Console.ReadLine());
            switch (ch)
            {
                case 1:
                    obj.accdeposit();
                    break;
                case 2:
                    obj.accwithdraw();
                    break;
                default:
                    Console.WriteLine("invalid!");
                    break;
            }
        }
        while (ch! == 0);
    }
}
   


            










