using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sandhya_oops_new
{
    
    internal class Executebank
    {
        static void Main(string[] args)
        {
            Bank b1 = new Bank();
            Bank b2 = new Bank();
            Bank b3 = new Bank();
            b1.openaccount(551, "ram", "ram@123", 3000);
            b2.openaccount(992, "ria", "ria#123", 2000);
            b3.openaccount(993, "tina", "tina@123", 4000);
            int c;
            int c1 = 0;
            string p;

            do
            {
                Console.WriteLine("ENTER YOUR LOGIN DETAILS");
                Console.WriteLine("ENTER USER NAME");
                string n1 = Console.ReadLine();
                Console.WriteLine("ENTER PASSWORD");
                string p1 = Console.ReadLine();

                if (b1.name == n1 && b1.password == p1)
                {
                    Console.WriteLine("WELCOME " + b1.name);

                    break;

                }
                else if (b2.name == n1 && b2.password == p1)
                {
                    Console.WriteLine("WELCOME " + b2.name);

                    break;
                }
                else if (b3.name == n1 && b3.password == p1)
                {
                    Console.WriteLine("WELCOME " + b3.name);
                }
                else
                {
                    Console.WriteLine("INVALID LOGIN DETAILS");
                    Console.WriteLine("PLEASE RETRY");
                    c1++;
                }
            } while (c1 < 2);






            do
            {
                Console.WriteLine(" 1.DEPOSIT MONEY");
                Console.WriteLine(" 2.WITHDRAW MONEY");
                Console.WriteLine(" 3.CHECK BALANCE");
                Console.WriteLine(" 4.DISPLAY DETAILS ");
                Console.WriteLine("ENTER  AN OPTION");


                c = Convert.ToInt32(Console.ReadLine());
                switch (c)
                {
                    case 1:
                        Console.WriteLine("enter amount to be deposited");
                        int m = Convert.ToInt32(Console.ReadLine());
                        b1.deposit(m);
                        break;
                    case 2:
                        Console.WriteLine("enter amount to be withdrawed");
                        int b = Convert.ToInt32(Console.ReadLine());
                        b1.withdrawal(b);
                        break;
                    case 3:
                        b1.checkbalance();
                        break;
                    case 4:
                        b1.display();
                        break;
                    default:
                        Console.WriteLine("INVALID OPTION");
                        break;


                }
                Console.WriteLine("DO YOU WANT TO CONTINUE WITH OTHER BANKING OPTIONS(yes/no");
                p = Console.ReadLine();
            } while (p != "no");

        }
    }
}
