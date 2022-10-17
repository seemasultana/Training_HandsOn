using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oops1
{
    public class server : Account, banking
    {
        public void display()
        {
            Console.WriteLine("your details :");
        }
    }
}
