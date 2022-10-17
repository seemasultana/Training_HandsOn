using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
     class bank 
    {
        public int balance;
        public string name;
        public int accno;

        



        public void withdrawal(int money)
        {
            if (money < balance)
            {
              balance = balance - money;
                Console.WriteLine("YOUR BALANCE AMOUNT IS :" + balance);
            }
            else
            {
                Console.WriteLine("YOU HAVE INSUFFICIENT BALANCE");
            }
        }
        public void deposit(int money)
        {
            balance = balance + money;
            Console.WriteLine("YOU HAVE DEPOSITED : " + money);
        }
        public void checkbalance()
        {
            Console.WriteLine("your current balance is  :" + balance);
        }
        public void display()
        {
            Console.WriteLine("ACCOUNT NO :" + accno);
            Console.WriteLine("ACCOUNT NAME :" + name);
            Console.WriteLine("ACCOUNT BALANCE :" + balance);
        }
        public void openaccount(int accno , string name , int bal)
        {
            this.accno = accno;
            this.name = name;
            this.balance = bal;
        }
    }
    abstract class bank1
    {
        public abstract void interestrate();
    }

    class SBI : bank1
    {
        public override void interestrate()
        {
            Console.WriteLine("The interest rate in SBI is 8.4%");
        }

    }
    class HDFC :bank1
    {
        public override void interestrate()
        {
            Console.WriteLine("THE INTEREST RATE IN HDFC IS 7.0%");
        }
    }

    class AXIS:bank1
    {
        public override void interestrate()
        {
            Console.WriteLine("THE INTEREST RATE IN AXIS BANK IS 9.7%");
        }
    }



    internal class sandhya
    {
        static void Main(string[] args)
        {
            bank b1 = new bank();
            
            bank b2 = new bank();
            b1.openaccount(991, "ram", 3000);
            b2.openaccount(992, "ria", 2000);
            int c;
            
            
            do 
            { 

            Console.WriteLine("showing example of abstraction");
            SBI a1 = new SBI();
            a1.interestrate();
            HDFC a2 = new HDFC();
            a2.interestrate();
            AXIS a3 = new AXIS();
            a3.interestrate();

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
            }while(c<=4);
            
            






        }
    }
}
