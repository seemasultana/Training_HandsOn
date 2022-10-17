using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oops1
{
    class Account : Bank
    {

        public override int accnum
        {
            get
            {
                return Accnum;
            }
            set
            {
                Accnum = value;
            }
        }
        string name;
        int deposit;
        private int accno;
        public override void accdeposit()
        {
            Console.WriteLine("enter account number:");
            accno = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter your name:");
            name = Console.ReadLine();
            Console.WriteLine(" enter amouunt to deposit:");
            deposit = Convert.ToInt32(Console.ReadLine());
            deposit += Accnum;
            Console.WriteLine("account number:" + accno);
            Console.WriteLine("account holder name:" + name);
            Console.WriteLine("balance amount:" + deposit);
        }
        public override void accwithdraw()
        {
            Console.WriteLine("account number:", accnum);
            accno = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(" account holder name:", name);
            name = Console.ReadLine();
            Console.WriteLine("withdraw amount:", deposit);
            deposit = Convert.ToInt32(Console.ReadLine());
            if (Accnum > 1000)
            {
                deposit -= Accnum;
                Console.WriteLine("balance amount:" + deposit);
            }
            else
            {
                Console.WriteLine("insufficient balance");
            }
        }
    }
}

