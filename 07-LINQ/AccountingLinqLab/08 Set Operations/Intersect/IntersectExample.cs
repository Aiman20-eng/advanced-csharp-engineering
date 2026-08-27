namespace AccountingLinqLab.SetOperations;

public static class IntersectExample
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

        var customersWithBoth =
            invoiceCustomers
                .Intersect(paymentCustomers);

        Console.WriteLine(
            "Customers with invoices and payments:");

        foreach (var customerId in customersWithBoth)
        {
            Console.WriteLine(customerId);
        }
    }
}