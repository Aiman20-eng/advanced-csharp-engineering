using AccountingLinqLab.Data;

namespace AccountingLinqLab.Partitioning;

public static class TakeExample
{
    public static void Run()
    {
        var invoices = AccountingData.Invoices
            .Take(3);

        Console.WriteLine("First 3 invoices:");

        foreach (var invoice in invoices)
        {
            Console.WriteLine(
                $"Invoice #{invoice.Id} | " +
                $"Amount: {invoice.Amount:N2}");
        }
    }
}