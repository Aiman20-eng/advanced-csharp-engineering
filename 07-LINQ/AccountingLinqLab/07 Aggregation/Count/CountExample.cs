using AccountingLinqLab.Data;

namespace AccountingLinqLab.Aggregation;

public static class CountExample
{
    public static void Run()
    {
        int totalInvoices =
            AccountingData.Invoices.Count();

        int unpaidInvoices =
            AccountingData.Invoices
                .Count(invoice => !invoice.IsPaid);

        Console.WriteLine(
            $"Total invoices: {totalInvoices}");

        Console.WriteLine(
            $"Unpaid invoices: {unpaidInvoices}");
    }
}