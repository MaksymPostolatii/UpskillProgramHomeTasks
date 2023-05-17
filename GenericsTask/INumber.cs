namespace GenericsTask;

public interface INumber<T>
{
    T Add(T other);
    T Subtract(T other);
    T Multiply(T other);
}