using AccountingLinqLab.Data;
using AccountingLinqLab.Models;

namespace AccountingLinqLab.ElementOperations;

public static class LastExample
{
    public static void Run()
    {
        Invoice invoice = AccountingData.Invoices
            .Last(invoice => !invoice.IsPaid);

        Console.WriteLine(
            $"Last unpaid invoice: #{invoice.Id} | " +
            $"Amount: {invoice.Amount:N2}");
    }
}