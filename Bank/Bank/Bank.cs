using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks; 

namespace Program
{
    public interface IBank   //interface
    {
         void SetInterestRate();  //interface method
    }
     
    public class Rbi : IBank   //base class
    {
         
        public void SetInterestRate()
        {
            Console.WriteLine("5%");
        }

        private void Denomination()  
        {
            Console.WriteLine("1000000 to be printed");
        }
    }
    class Hdfc : IBank     //derived class
    {
        
        public  void  SetInterestRate()
        {
            Console.WriteLine("7%");
        } 

       public Double RateOfInterest = 8.5; // set interest for home loan
    }
    

    class Program
    {
        static void Main(string[] args)
        {
            Rbi rbi = new Rbi();   //object creation for Rbi
            Console.Write("\nInterest rate as per RBI regulations:");
            rbi.SetInterestRate();

            Hdfc hdfc = new Hdfc();  // object creation for Hdfc
            Console.Write("\nInterest rate as per HDFC Bank:");
            hdfc.SetInterestRate();

            Console.Write("\nRate of Interest for Home loan:");
            Console.WriteLine(hdfc.RateOfInterest+"%");

            // Find simple Interest

            Console.WriteLine("\nTo find Simple Interest");
            Console.WriteLine("Enter Principal amount: ");
            Double Principal = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter number of months:");
            Double Months = Convert.ToDouble(Console.ReadLine());

            
            Console.WriteLine("Total Repayment:"+(Principal*Months* hdfc.RateOfInterest)/100);
           
        }
    }
}
