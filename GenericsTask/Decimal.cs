namespace GenericsTask;

public class Decimal : INumber<Decimal>
{
    private readonly decimal _value;

    public Decimal(decimal value)
    {
        _value = value;
    }

    public Decimal Add(Decimal other)
    {
        return new Decimal(_value + other._value);
    }

    public Decimal Subtract(Decimal other)
    {
        return new Decimal(_value - other._value);
    }

    public Decimal Multiply(Decimal other)
    {
        return new Decimal(_value * other._value);
    }

    public override string ToString()
    {
        return _value.ToString();
    }
}