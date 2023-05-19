namespace LinqTask;

public static class LinqUtil
{
    //Task #1
    public static int GetNextNumber(int inputNumber) =>
        Enumerable.Range(inputNumber + 1, 1)
            .FirstOrDefault();

    //Task #2
    public static IEnumerable<string> GetSortedValuesByPattern(IEnumerable<string> values, string pattern) =>
        from value in values
        where value.Contains(pattern)
        orderby value
        select value;

    //Task #3
    public static IEnumerable<string> GetSortedValuesMethodSyntaxByPattern(IEnumerable<string> values, string pattern) =>
        values.Where(value => value.Contains(pattern))
            .OrderBy(value => value);

    //Task #4
    public static IEnumerable<T> GetNextThreeCollectionItems<T>(IEnumerable<T> values, int itemsToSkip) =>
        values.Skip(itemsToSkip)
            .Take(3);

    //Task #5
    public static IEnumerable<string> GetElementsBetween(IEnumerable<string> values, string start, string end) =>
        values.SkipWhile(word => word != start)
            .TakeWhile(word => word != end);

    //Task #6
    public static IEnumerable<string> GetDistinctShortWords(IEnumerable<string> values) =>
        values.Where(value => value.Length < 4)
            .Distinct();

    //Task #7
    public static IEnumerable<Name> OrderNamesByLastNameDescending(IEnumerable<Name> names) => 
        names.OrderByDescending(name => name.Last);

    //Task #8
    public static IEnumerable<Name> OrderNamesByLastMiddleFirstDescending(IEnumerable<Name> names) =>
        names.OrderByDescending(name => name.Last)
            .ThenByDescending(name => name.Middle)
            .ThenByDescending(name => name.First);

    //Task #9
    public static int CountStringsWithStart(IEnumerable<string> values, string startString) => 
        values.Count(value => value.StartsWith(startString));

    //Task #10
    public static int GetLengthOfShortestWordInList(IEnumerable<string> values) => 
        values.Min(value => value.Length);

    //Task #11
    public static int GetTotalCharactersCount(IEnumerable<string> values) => 
        values.Sum(value => value.Length);

    //Task #12
    public static IEnumerable<string> GetFormattedNames(IEnumerable<Name> names) => 
        names.Select(name => $"{name.Last}, {name.First}");

    //Task #13
    public static string? GetLastWordWithCharacterE(IEnumerable<string> values) =>
        values.Where(value => value.Contains('e'))
            .OrderBy(value => value)
            .Select(lastValue => $"The last word is {lastValue}")
            .DefaultIfEmpty(null)
            .LastOrDefault();
}