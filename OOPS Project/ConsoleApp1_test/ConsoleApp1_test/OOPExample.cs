using System;

namespace OOPExample
{
    public abstract class Calculator
    {
        public abstract void Sum(int num1, int num2);
        public abstract void sub(int num1, int num2);
        public abstract void mul(int num1, int num2);
        public abstract void div(int num1, int num2);
    }
    interface IOperations
    {
        public void show();
    }
    public class calculations1 : Calculator
    {
        public virtual void sum(int num1, int num2, int num3)
        {
            Console.WriteLine($"Addition of {num1} and {num2} and {num3} is {num1 + num2 + num3} ");
        }
        public override void Sum(int num1, int num2)
        {
            Console.WriteLine($"Addition of {num1} and {num2} is {num1 + num2} ");
        }
        public override void sub(int num1, int num2)
        {
            Console.WriteLine($"Substarction of {num1} and {num2} is {num1 - num2} ");
        }
        public override void mul(int num1, int num2)
        {
            Console.WriteLine($"Multiplication of {num1} and {num2} is {num1 * num2} ");
        }
        public override void div(int num1, int num2)
        {
            Console.WriteLine($"Division of {num1} and {num2} is {num1 / num2} ");
        }
    }
    public class calculations2 : calculations1, IOperations
    {
        public void show()
        {
            Console.WriteLine("The result of all operations are  ");
        }
    }
    class OOPExample
    {
        static void Main(string[] args)
        {
            Console.Write("-------------------------CALCULATOR-------------------------\n");
            Console.Write("Enter the first number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the second number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the third number: ");
            int num3 = Convert.ToInt32(Console.ReadLine());
            calculations2 c = new calculations2();
            c.show();
            c.sum(num1, num2, num3);
            c.Sum(num1, num2);
            c.sub(num1, num2);
            c.mul(num1, num2);
            c.div(num1, num2);
        }
    }
}
