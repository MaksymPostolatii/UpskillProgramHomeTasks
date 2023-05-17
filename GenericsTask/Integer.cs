namespace GenericsTask;

internal class Integer : INumber<Integer>
{
    private readonly int _value;

    public Integer(int value)
    {
        _value = value;
    }

    public Integer Add(Integer other)
    {
        return new Integer(_value + other._value);
    }

    public Integer Subtract(Integer other)
    {
        return new Integer(_value - other._value);
    }

    public Integer Multiply(Integer other)
    {
        return new Integer(_value * other._value);
    }

    public override string ToString()
    {
        return _value.ToString();
    }
}