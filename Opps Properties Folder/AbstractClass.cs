namespace Abs_Calculator
{
    public abstract class Abstract_opeartion
    {
      
        public abstract int Abs_add(int a, int b);
        public abstract int Abs_add(int a, int b, int c);
        public int Abs_Mult(int a, int b)
            { return a * b; }
        public virtual int Abs_Div(int a, int b)
        { return a / b; }
        public Abstract_opeartion()
        {
            Console.WriteLine("Constructor Of Abstract Class");

        }
    }
    public class AbstractClass : Abstract_opeartion
    {
        public override int Abs_add(int a, int b, int c)
            { return a + b+c; }
        public override int Abs_add(int a, int b)
        {
            return a + b;
        }
        public override int Abs_Div(int a, int b)
        { return a * b; }
    }
       
        }

