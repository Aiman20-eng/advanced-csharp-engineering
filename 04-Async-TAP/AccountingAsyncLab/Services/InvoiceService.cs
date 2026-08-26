using AccountingAsyncLab.Models;

namespace AccountingAsyncLab.Services;

public class InvoiceService
{
    public async Task<decimal> GetTotalInvoicesAsync(
        CancellationToken cancellationToken)
    {
        Console.WriteLine("Loading invoices...");

        await Task.Delay(1000, cancellationToken);

        List<Invoice> invoices =
        [
            new Invoice
            {
                Id = 1,
                CustomerName = "Customer A",
                Amount = 20000
            },

            new Invoice
            {
                Id = 2,
                CustomerName = "Customer B",
                Amount = 30000
            }
        ];

        decimal total = invoices.Sum(invoice => invoice.Amount);

        Console.WriteLine(
            $"Invoices loaded. Total = {total:N2}");

        return total;
    }
}