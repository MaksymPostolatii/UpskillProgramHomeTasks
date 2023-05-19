using LinqTask;
using static System.Console;
using static LinqTask.LinqUtil;

internal class Program
{
    public static void Main(string[] args)
    {
        const string apPattern = "ap";
        const string anPattern = "an";
        const string mango = "4 - mango";
        const string pomegranate = "6 - pomegranate";
        const string nStart = "n";
        const int number = 5;
        const int itemsToSkip = 2;
        
        var fruits = new List<string>
        {
            "1 - apple",
            "2 - banana",
            "3 - grape",
            "4 - mango",
            "5 - orange",
            "6 - pomegranate",
            "7 - pineapple",
            "pineapple",
            "nut",
            "nut"
        };

        var names = new List<Name>
        {
            new() { First = "Rick", Middle = "A", Last = "Grimes" },
            new() { First = "Rick", Middle = "C", Last = "Grimes" },
            new() { First = "Rick", Middle = "C", Last = "Crimes" },
            new() { First = "Daryl", Middle = "Jr", Last = "Dixon" },
            new() { First = "Eugene", Middle = "Dr", Last = "Porter" }
        };

        WriteLine("Task result #1:");
        WriteLine(GetNextNumber(number));

        WriteLine("\nTask result #2:");
        GetSortedValuesByPattern(fruits, apPattern).ToList().ForEach(WriteLine);

        WriteLine("\nTask result #3:");
        GetSortedValuesMethodSyntaxByPattern(fruits, anPattern).ToList().ForEach(WriteLine);

        WriteLine("\nTask result #4:");
        GetNextThreeCollectionItems(fruits, itemsToSkip).ToList().ForEach(WriteLine);

        WriteLine("\nTask result #5:");
        GetElementsBetween(fruits, mango, pomegranate).ToList().ForEach(WriteLine);

        WriteLine("\nTask result #6:");
        GetDistinctShortWords(fruits).ToList().ForEach(WriteLine);

        WriteLine("\nTask result #7:");
        OrderNamesByLastNameDescending(names).ToList().ForEach(WriteLine);

        WriteLine("\nTask result #8:");
        OrderNamesByLastMiddleFirstDescending(names).ToList().ForEach(WriteLine);

        WriteLine("\nTask result #9:");
        WriteLine(CountStringsWithStart(fruits, nStart));

        WriteLine("\nTask result #10:");
        WriteLine(GetLengthOfShortestWordInList(fruits));

        WriteLine("\nTask result #11:");
        WriteLine(GetTotalCharactersCount(fruits));

        WriteLine("\nTask result #12:");
        WriteLine(string.Join("\n", GetFormattedNames(names)));

        WriteLine("\nTask result #13:");
        WriteLine(GetLastWordWithCharacterE(fruits));
    }
}