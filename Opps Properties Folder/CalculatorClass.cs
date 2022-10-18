

namespace Calculator
{
    public class Arithmetic_Opeartion
    {
        public int Add(int a, int b)
            { return a + b; }
        private int Sub(int a, int b)
            { return a - b; }
        protected int Mult(int a, int b)
            { return a * b; }
        internal int Div(int a, int b)
            { return a / b; }
        internal protected int Mod(int a, int b)
            { return a % b; }
    }
    public  class Extra_Operation:Arithmetic_Opeartion
        {
        public int Add(int a, int b, int c)
        { return a + b + c; }
        public void MultTest()
            {
            System.Console.WriteLine(Mult(2,3));
            }
        
        }
}
// Inheritance, Overloading(Polymorphism),Encapsulation
