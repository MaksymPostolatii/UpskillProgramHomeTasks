using static System.Console;

namespace CollectionsTask;

internal class Program
{
    public static void Main(string[] args)
    {
        var shoppingItemsList = new List<ShoppingItem>
        {
            new() { Name = "Orange Juice", Price = 3.99m, Quantity = 2 },
            new() { Name = "Bread", Price = 0.99m, Quantity = 1 },
            new() { Name = "Milk", Price = 1.99m, Quantity = 2 },
            new() { Name = "Kinder Surprise", Price = 0.49m, Quantity = 3 },
            new() { Name = "Coca Cola", Price = 1.49m, Quantity = 1 }
        };

        foreach (var item in shoppingItemsList)
        {
            WriteLine(item);
        }

        ReadKey();
    }
}