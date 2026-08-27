using AccountingLinqLab.Data;
using AccountingLinqLab.Models;

namespace AccountingLinqLab.ElementOperations;

public static class FirstExample
{
    public static void Run()
    {
        Invoice invoice = AccountingData.Invoices
            .First(invoice => !invoice.IsPaid);

        Console.WriteLine(
            $"First unpaid invoice: #{invoice.Id} | " +
            $"Amount: {invoice.Amount:N2}");
    }
}