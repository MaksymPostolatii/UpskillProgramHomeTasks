namespace CollectionsTask;

public class ShoppingItem
{
    public string Name { get; init; }
    public decimal Price { get; init; }
    public int Quantity { get; init; }

    public override string ToString()
    {
        return $"Name: {Name} Price: {Price} Quantity: {Quantity}";
    }
}