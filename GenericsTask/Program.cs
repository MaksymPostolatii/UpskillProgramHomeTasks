using static System.Console;

namespace GenericsTask;

internal class Program
{
    public static void Main(string[] args)
    {
        Integer[,] intData = { { new(1), new(2) }, { new(3), new(4) } };
        var intMatrix = new Matrix<Integer>(intData);
        
        Double[,] doubleData = { { new(1.1), new(2.2) }, { new(3.3), new(4.4) } };
        var doubleMatrix = new Matrix<Double>(doubleData);
        
        Decimal[,] decimalData = { { new(1.11m), new(2.22m) }, { new(3.33m), new(4.44m) } };
        var decimalMatrix = new Matrix<Decimal>(decimalData);
        
        var multiplier = new Decimal(2);
        
        WriteLine("Integer Matrix:");
        WriteLine(intMatrix);
        intMatrix.Add(intMatrix);
        WriteLine("Integer matrix after addition:");
        WriteLine(intMatrix);

        WriteLine("Double Matrix:");
        WriteLine(doubleMatrix);
        doubleMatrix.Subtract(doubleMatrix);
        WriteLine("Double matrix after subtraction:");
        WriteLine(doubleMatrix);

        WriteLine("Decimal Matrix:");
        WriteLine(decimalMatrix);
        decimalMatrix.Multiply(multiplier);
        WriteLine("Decimal matrix after multiplication by: {0}", multiplier);
        WriteLine(decimalMatrix);

        WriteLine("Press any key to exit.");
        ReadKey();
    }
}