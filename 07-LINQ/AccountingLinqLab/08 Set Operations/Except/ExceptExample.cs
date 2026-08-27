namespace AccountingLinqLab.SetOperations;

public static class ExceptExample
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

        var customersWithInvoicesOnly =
            invoiceCustomers
                .Except(paymentCustomers);

        Console.WriteLine(
            "Customers with invoices but no payments:");

        foreach (var customerId in customersWithInvoicesOnly)
        {
            Console.WriteLine(customerId);
        }
    }
}