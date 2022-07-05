public class Program
{
    public static void Main(string[] args)
    {
        Example2();
    }

    public static void Example1()
    {
        Function myFunc = new Function(new Add(3), new Multi(5), new Divi(2));
        var output = myFunc.Eval(5);
        myFunc.Print();
        System.Console.WriteLine("Output: " + output);
    }

    public static void Example2()
    {
        Function myFunc = new Function(Function.sin, Function.cos, Function.tan);
        var output = myFunc.Eval(5);
        myFunc.Print();
        System.Console.WriteLine("Output: " + output);
    }
}
