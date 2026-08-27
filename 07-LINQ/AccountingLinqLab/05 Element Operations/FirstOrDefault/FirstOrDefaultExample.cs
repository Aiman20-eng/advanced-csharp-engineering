using AccountingLinqLab.Data;
using AccountingLinqLab.Models;

namespace AccountingLinqLab.ElementOperations;

public static class FirstOrDefaultExample
{
    public static void Run()
    {
        Invoice? invoice = AccountingData.Invoices
            .FirstOrDefault(invoice => invoice.Id == 1003);

        if (invoice is null)
        {
            Console.WriteLine("Invoice not found.");
            return;
        }

        Console.WriteLine(
            $"Invoice found: #{invoice.Id} | " +
            $"Amount: {invoice.Amount:N2}");
    }
}