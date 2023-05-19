namespace LinqTask;

public class Name
{
    public string First { get; init; }
    public string Middle { get; init; }
    public string Last { get; init; }

    public override string ToString()
    {
        return $"{First} {Middle} {Last}";
    }
}