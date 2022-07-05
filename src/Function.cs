public class MultiFunc
{
    Function[] functions;
    Operation[] opBetnFuncs;
    public MultiFunc(Function[] functions, Operation[] opBetnFuncs)
    {
        if (opBetnFuncs.Length > functions.Length - 1)
            System.Console.Write("Error!!");
        this.functions = functions;
        this.opBetnFuncs = opBetnFuncs;
    }

    public float Eval(float input)
    {

        float[] functionOutputs = new float[functions.Length];
        for (int i = 0; i < functions.Length; i++)
            functionOutputs[i] = functions[i].Eval(input);

        for (int i = 0; i < opBetnFuncs.Length; i++)
        {
            // TODO
        }

        return 1;
    }
}

public class Function
{
    public static readonly Operation sin = new Sin();
    public static readonly Operation cos = new Cos();
    public static readonly Operation tan = new Tan();
    Operation[] operations;

    public Function(params Operation[] operations)
    {
        this.operations = operations;
    }

    public float Eval(float input)
    {
        float current = input;
        foreach (Operation op in operations)
            current = op.Apply(current);

        return current;
    }

    public void Print()
    {
        System.Console.Write("Function: ");
        operations[0].Print();
        for (int i = 1; i < operations.Length; i++)
        {
            System.Console.Write(", ");
            operations[i].Print();
        }
        System.Console.Write("\n");
    }
}


public abstract class Operation
{
    public abstract string name { get; }
    public abstract float value { get; set; }
    public abstract float Apply(float input);
    public abstract void Print();
}
public class Add : Operation
{
    public override string name { get; }
    public override float value { get; set; }
    public Add(float value)
    {
        this.value = value;
        this.name = "Add";
    }
    public override float Apply(float input) => input + value;
    public override void Print() => System.Console.Write(name + " " + value);
}
public class Subtract : Operation
{
    public override string name { get; }
    public override float value { get; set; }
    public Subtract(float value)
    {
        this.value = value;
        this.name = "Subtract";
    }
    public override float Apply(float input) => input - value;
    public override void Print() => System.Console.Write(name + " " + value);
}
public class Multi : Operation
{
    public override string name { get; }
    public override float value { get; set; }
    public Multi(float value)
    {
        this.value = value;
        this.name = "Multi";
    }
    public override float Apply(float input) => input * value;
    public override void Print() => System.Console.Write(name + " " + value);
}
public class Divi : Operation
{
    public override string name { get; }
    public override float value { get; set; }
    public Divi(float value)
    {
        this.value = value;
        this.name = "Divi";
    }
    public override float Apply(float input) => input / value;
    public override void Print() => System.Console.Write(name + " " + value);
}
public class Sin : Operation
{
    public override string name { get; }
    public override float value { get; set; }
    public Sin()
    {
        this.name = "Sin";
    }
    public override float Apply(float input) => MathF.Sin(input);
    public override void Print() => System.Console.Write(name);
}
public class Cos : Operation
{
    public override string name { get; }
    public override float value { get; set; }
    public Cos()
    {
        this.name = "Cos";
    }
    public override float Apply(float input) => MathF.Cos(input);
    public override void Print() => System.Console.Write(name);
}
public class Tan : Operation
{
    public override string name { get; }
    public override float value { get; set; }
    public Tan()
    {
        this.name = "Tan";
    }
    public override float Apply(float input) => MathF.Tan(input);
    public override void Print() => System.Console.Write(name);
}