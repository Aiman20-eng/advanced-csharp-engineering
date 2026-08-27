namespace AccountingLinqLab.Quantifiers;

public static class ContainsExample
{
    public static void Run()
    {
        var customerIds = new List<int>
        {
            1,
            2,
            3,
            4
        };

        bool containsCustomer =
            customerIds.Contains(3);

        Console.WriteLine(
            $"Contains customer 3: {containsCustomer}");
    }
}