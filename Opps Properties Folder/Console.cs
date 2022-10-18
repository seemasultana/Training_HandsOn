using Calculator;
using Abs_Calculator;

Extra_Operation obj = new Extra_Operation();
Console.WriteLine(obj.Add(2,3));
Console.WriteLine(obj.Add(3,4,5));
Console.WriteLine(obj.Div(4,5));
obj.MultTest();
AbstractClass obj2 = new AbstractClass();
Console.WriteLine(obj2.Abs_add(2,3));
Console.WriteLine(obj2.Abs_add(2, 3, 4));
Console.WriteLine(obj2.Abs_Mult(2, 3));
Console.WriteLine(obj2.Abs_Div(2, 3));

Operation obj3 = new Operation();
Console.WriteLine(obj3.add(4,5));
Console.WriteLine(obj3.subtract(20,10));
Console.WriteLine(obj3.multiply(23,24));
Console.WriteLine(obj3.mod(2,4));
Console.WriteLine(obj3.divide(234,12));
