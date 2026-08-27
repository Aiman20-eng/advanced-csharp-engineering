using AccountingLinqLab.Data;

namespace AccountingLinqLab.Partitioning;

public static class TakeWhileExample
{
    public static void Run()
    {
        var invoices = AccountingData.Invoices
            .OrderBy(invoice => invoice.Amount)
            .TakeWhile(invoice => invoice.Amount < 20_000);

        Console.WriteLine(
            "Invoices while amount is below 20,000:");

        foreach (var invoice in invoices)
        {
            Console.WriteLine(
                $"Invoice #{invoice.Id} | " +
                $"Amount: {invoice.Amount:N2}");
        }
    }
}