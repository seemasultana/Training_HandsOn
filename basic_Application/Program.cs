using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace basi_Application
{
   public interface Vehicle
    {
         
        void no_of_passengers(string a);
    }
   abstract class Vehicles
    {
        public Vehicles()
        {
            Console.WriteLine("CAR");
        }
    }
    public class Car
    {
        public string color;
        protected string car_model;
        private string car_name;
        
        

        public string car_Name   // encapsulation
        {
            get { return car_name; }   // get method
            set { car_name = value; }
        }
        
        public Car()//Default Constructor it is called whenever object of class is created.
        {
            Console.WriteLine("Cars Constructor called  using object of parent class");
        }
        
        public void no_of_passengers(string a,string b)//Method overloading means we can use same method name with different parameters
        {
            Console.WriteLine("Two seater Maruti Car");
        }
        public void no_of_passengers(string c,string d ,string e)
        {
            Console.WriteLine("Three seater Maruti Car");
        }
        public void car_company()
        {
            Console.WriteLine("All are maruti suzuki's cars");

        }
        




    }
    public class Program
    {
        static void Main()
        {
            Car c = new Car();
            c.car_Name = "Tejasi";
            Console.WriteLine(c.car_Name);
            //Console.WriteLine(c.car_id);
            
            c.color = "All Blue Cars of Same Brand Parent class Maruti";
            Console.WriteLine(c.color);
            
            
            //Console.WriteLine(c.car_no);
            
            
            Swift sw = new Swift();
            //Console.WriteLine(sw.color);
            sw.color = "Yellow SWIFT Cars which is the child class of Parent class Maruti";
            
            Console.WriteLine(sw.color);
            sw.no_of_passengers("Ria", "Raj");
            sw.no_of_passengers("rian", "michhael", "merry");
            sw.car_modelname();
            sw.car_company();
            sw.car_info();
            
            Nexa nx = new Nexa();
            nx.color = "Red NEXA";
            Console.WriteLine(nx.color);
            nx.Engine();
            nx.Airbags();
            nx.powerlocking();
            Breza bw = new Breza();
            bw.color = "black BRESZA";
            Console.WriteLine(bw.color);
            bw.Airbags();
            bw.powerlocking();
            bw.Engine();
            bw.car_modelname();
            bw.sunroof();
            

            

            
        }
    }
}
