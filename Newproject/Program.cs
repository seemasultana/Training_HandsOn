using Newproject;
using System;

namespace Newproject
{
    abstract class title // abstract class
    {
        public abstract void write();//abstract method
    }
    class employee : title //inheriting title from abstract class //base class
    {
        public string name    = "Rajasutha R";
        private int batch      = 2022;
        public string location= "Bangalore";
        public string company;

        public employee() //constructor class  
        {
            company = "HARMAN";
        }
        public void symbol() //polymorphism
        {
            Console.WriteLine("______________");
        }
        public override void write() //implementation of that abstract method //overriding from base class
        {
            Console.WriteLine("Employer Details");
        }
    }
    class detail:employee //child class
    {
        public string designation = "Associate Engineer";
        public string GOC         = "System C healthcare";
        public string manager     = "Zulquar";

        public void Symbol()//polymorphism
        {
            Console.WriteLine("***************");
        }
    }
}
class program
{
    static void Main(string[]args)
    {
        detail myproj = new detail();//myproj is an object
        //Console.WriteLine(myproj.batch);

        Console.WriteLine("Welcome to " + myproj.company + "\n");//constructor 

        myproj.symbol();//polymorphism

        myproj.write();//abstraction

        Console.WriteLine("\n" +"\nName        :"+ myproj.name + 
                          "\nDesignation :"+ myproj.designation +
                          "\nGOC         :"+myproj.GOC +" "  +
                          "\nManager     :"+myproj.manager);
    }
}



        
        
        
        
        
    