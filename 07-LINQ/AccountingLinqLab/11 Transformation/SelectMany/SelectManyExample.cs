using AccountingLinqLab.Data;

namespace AccountingLinqLab.Transformation;

public static class SelectManyExample
{
    public static void Run()
    {
        var invoices =
            AccountingData.Customers
                .SelectMany(customer => customer.Invoices);

        Console.WriteLine(
            "=== All Customer Invoices ===");

        foreach (var invoice in invoices)
        {
            Console.WriteLine(
                $"Invoice #{invoice.Id} | " +
                $"Amount: {invoice.Amount:N2}");
        }
    }
}