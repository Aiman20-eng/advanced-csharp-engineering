namespace AccountingLinqLab.SetOperations;

public static class UnionExample
{
    public static void Run()
    {
        var invoiceCustomers = new List<int>
        {
            1, 2, 3, 4
        };

        var paymentCustomers = new List<int>
        {
            2, 3, 4, 5
        };

        var allCustomers =
            invoiceCustomers
                .Union(paymentCustomers);

        Console.WriteLine("All active customers:");

        foreach (var customerId in allCustomers)
        {
            Console.WriteLine(customerId);
        }
    }
}