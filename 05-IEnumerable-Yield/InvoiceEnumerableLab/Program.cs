using InvoiceEnumerableLab.Models;
using InvoiceEnumerableLab.Services;

List<Invoice> invoices =
[
    new Invoice
    {
        Id = 1,
        CustomerName = "Customer A",
        Amount = 5_000
    },

    new Invoice
    {
        Id = 2,
        CustomerName = "Customer B",
        Amount = 15_000
    },

    new Invoice
    {
        Id = 3,
        CustomerName = "Customer C",
        Amount = 8_000
    },

    new Invoice
    {
        Id = 4,
        CustomerName = "Customer D",
        Amount = 25_000
    },

    new Invoice
    {
        Id = 5,
        CustomerName = "Customer E",
        Amount = 3_000
    }
];

InvoiceService service = new();

Console.WriteLine("Creating enumerable...");

IEnumerable<Invoice> largeInvoices =
    service.GetInvoicesAboveAmount(
        invoices,
        10_000);

Console.WriteLine("Enumerable created.");

Console.WriteLine();
Console.WriteLine("Starting enumeration...");
Console.WriteLine();

foreach (var invoice in largeInvoices)
{
    Console.WriteLine(
        $"RESULT → Invoice #{invoice.Id} | " +
        $"Customer: {invoice.CustomerName} | " +
        $"Amount: {invoice.Amount:N2}");

    Console.WriteLine();
}

Console.WriteLine("Enumeration completed.");