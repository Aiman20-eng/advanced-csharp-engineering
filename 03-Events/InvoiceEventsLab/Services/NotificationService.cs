using InvoiceEventsLab.Models;

namespace InvoiceEventsLab.Services;

public class NotificationService
{
    public void NotifyInvoiceCreated(Invoice invoice)
    {
        Console.WriteLine(
            $"[NOTIFICATION] Invoice #{invoice.Id} " +
            $"notification sent."
        );
    }
}