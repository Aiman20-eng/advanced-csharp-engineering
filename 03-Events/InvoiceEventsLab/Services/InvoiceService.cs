using InvoiceEventsLab.Events;
using InvoiceEventsLab.Models;

namespace InvoiceEventsLab.Services;

public class InvoiceService
{
    public event InvoiceCreatedEventHandler? InvoiceCreated;

    public Invoice CreateInvoice(
        int id,
        string customerName,
        decimal amount)
    {
        Invoice invoice = new()
        {
            Id = id,
            CustomerName = customerName,
            Amount = amount
        };

        Console.WriteLine(
            $"Invoice #{invoice.Id} created."
        );

        InvoiceCreated?.Invoke(invoice);

        return invoice;
    }
}