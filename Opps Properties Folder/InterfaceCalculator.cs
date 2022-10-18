
namespace Calculator
{
    public interface InterfaceCalculator
    {
        int add(int a, int b);
        int subtract(int a, int b);
        int multiply(int a, int b);
    }
    public interface ExtraInterface
    {
        int divide(int a, int b);
        int mod(int a, int b);
    }
    public class Operation: InterfaceCalculator,ExtraInterface
    {
        public int add(int a, int b)
        { return a + b; }
            
       public int subtract(int a, int b)
        { return a - b; }
        public int multiply(int a, int b)
        { return a * b; }
        public int divide(int a, int b)
        { return a / b; }
       public int mod(int a, int b)
        { return a % b; }
    }

}
