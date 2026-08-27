using AccountingLinqLab.Data;
using AccountingLinqLab.Models;

namespace AccountingLinqLab.ElementOperations;

public static class SingleOrDefaultExample
{
    public static void Run()
    {
        Invoice? invoice = AccountingData.Invoices
            .SingleOrDefault(invoice => invoice.Id == 9999);

        if (invoice is null)
        {
            Console.WriteLine("Invoice does not exist.");
            return;
        }

        Console.WriteLine(
            $"Invoice found: #{invoice.Id}");
    }
}