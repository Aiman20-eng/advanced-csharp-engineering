using AccountingLinqLab.Data;

namespace AccountingLinqLab.Quantifiers;

public static class AnyExample
{
    public static void Run()
    {
        bool hasUnpaidInvoices =
            AccountingData.Invoices
                .Any(invoice => !invoice.IsPaid);

        Console.WriteLine(
            $"Has unpaid invoices: {hasUnpaidInvoices}");
    }
}