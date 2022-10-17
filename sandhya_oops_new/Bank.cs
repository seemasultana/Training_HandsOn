using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sandhya_oops_new
{


    class Bank
    {
        public int balance;
        public string name;
        public string password;
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
        public void openaccount(int accno, string name, string password, int bal)
        {
            this.accno = accno;
            this.name = name;
            this.password = password;
            this.balance = bal;
        }
    }
}
