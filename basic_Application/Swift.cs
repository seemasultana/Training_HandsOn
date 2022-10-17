using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basi_Application
{
    internal class Swift: Car
    {
        private string car_id = "UP233AZ69";
        string car_model = "343467B";
        public Swift()
        {
            Console.WriteLine("Swift Cars Default Constructor");
        }
        public void car_modelname()
        {
            Console.WriteLine("XL Swift Car");
        }
        public  void Engine()
        {
            Console.WriteLine("1197 cc engine Swift Car");
        }
        public void Airbags()
        {
            Console.WriteLine("In Swift Cars Airbags Available - Driver frontal airbag, front passenger front airbag");
        }
        public void powerlocking()
        {
            Console.WriteLine("No Powerlocking in swift Car");
        }
        public void sunroof()
        {
            Console.WriteLine("No Sunroof available in Swift Cars ");
        }
        public void car_info()
        {
            Console.WriteLine("Car id and Car Model of Swift Car:" + car_id + " , " + car_model);
        }
    }
}
