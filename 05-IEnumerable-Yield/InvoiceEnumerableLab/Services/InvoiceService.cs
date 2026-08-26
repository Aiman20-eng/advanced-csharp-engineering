using InvoiceEnumerableLab.Models;

namespace InvoiceEnumerableLab.Services;

public class InvoiceService
{
    public IEnumerable<Invoice> GetInvoicesAboveAmount(
        IEnumerable<Invoice> invoices,
        decimal minimumAmount)
    {
        foreach (var invoice in invoices)
        {
            Console.WriteLine(
                $"Checking Invoice #{invoice.Id}...");

            if (invoice.Amount >= minimumAmount)
            {
                Console.WriteLine(
                    $"Invoice #{invoice.Id} qualifies.");

                yield return invoice;
            }
        }
    }
}