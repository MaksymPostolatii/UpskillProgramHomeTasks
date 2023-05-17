namespace GenericsTask;

public class Matrix<T> where T: INumber<T>
{
    private readonly T[,] _data;

    public Matrix(T[,] data)
    {
        _data = data;
    }

    public void Add(Matrix<T> other)
    {
        if (_data.GetLength(0) != other._data.GetLength(0) ||
            _data.GetLength(1) != other._data.GetLength(1))
        {
            throw new ArgumentException("Matrices should have the same dimensions for addition.");
        }

        for (var i = 0; i < _data.GetLength(0); i++)
        {
            for (var j = 0; j < _data.GetLength(1); j++)
            {
                _data[i, j] = _data[i, j].Add(other._data[i, j]);
            }
        }
    }

    public void Subtract(Matrix<T> other)
    {
        if (_data.GetLength(0) != other._data.GetLength(0) ||
            _data.GetLength(1) != other._data.GetLength(1))
        {
            throw new ArgumentException("Matrices should have the same dimensions for subtraction.");
        }

        for (var i = 0; i < _data.GetLength(0); i++)
        {
            for (var j = 0; j < _data.GetLength(1); j++)
            {
                _data[i, j] = _data[i, j].Subtract(other._data[i, j]);
            }
        }
    }

    public void Multiply(T scalar)
    {
        for (var i = 0; i < _data.GetLength(0); i++)
        {
            for (var j = 0; j < _data.GetLength(1); j++)
            {
                _data[i, j] = _data[i, j].Multiply(scalar);
            }
        }
    }

    public override string ToString()
    {
        var result = "";
        for (var i = 0; i < _data.GetLength(0); i++)
        {
            for (var j = 0; j < _data.GetLength(1); j++)
            {
                result += _data[i, j] + " ";
            }
            result += "\n";
        }
        return result;
    }
}