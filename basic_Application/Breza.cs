using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basi_Application
{
    internal class Breza : Nexa
    {
        public Breza()
        {
            Console.WriteLine("Breza Cars default Constructor");
        }
        public void Engine_nexa()
        {
            Console.WriteLine("1000 cc engine in Breza Car");
        }
        public void Airbags()
        {
            Console.WriteLine("Driver frontal airbag, front passenger front airbag in Breza Car");
        }
        public void powerlocking()
        {
            Console.WriteLine("No Powerlocking in Nexa Car");
        }
        public void wheels()
        {
            Console.WriteLine("Four wheels in Breza Car");
        }
    }

}

