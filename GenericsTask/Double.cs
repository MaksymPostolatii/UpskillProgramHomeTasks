namespace GenericsTask;

public class Double : INumber<Double>
{
    private readonly double _value;

    public Double(double value)
    {
        _value = value;
    }

    public Double Add(Double other)
    {
        return new Double(_value + other._value);
    }

    public Double Subtract(Double other)
    {
        return new Double(_value - other._value);
    }

    public Double Multiply(Double other)
    {
        return new Double(_value * other._value);
    }

    public override string ToString()
    {
        return _value.ToString();
    }
}