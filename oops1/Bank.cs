using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oops1
{
    public abstract class Bank
    {
        protected int Accnum = 10000;
        public abstract int accnum
        {
            get;
            set;
        }
        public abstract void accdeposit();
        public abstract void accwithdraw();
    }
}
