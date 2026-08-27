using AccountingLinqLab.Data;

namespace AccountingLinqLab.Quantifiers;

public static class AllExample
{
    public static void Run()
    {
        bool allInvoicesArePaid =
            AccountingData.Invoices
                .All(invoice => invoice.IsPaid);

        Console.WriteLine(
            $"Are all invoices paid? {allInvoicesArePaid}");
    }
}