using InvoiceEventsLab.Models;

namespace InvoiceEventsLab.Services;

public class AuditLogger
{
    public void LogInvoiceCreated(Invoice invoice)
    {
        Console.WriteLine(
            $"[AUDIT] Invoice #{invoice.Id} created " +
            $"for customer {invoice.CustomerName}."
        );
    }
}