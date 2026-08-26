using InvoiceEventsLab.Services;
using InvoiceEventsLab.Models;

InvoiceService invoiceService = new();

AuditLogger auditLogger = new();

NotificationService notificationService = new();

invoiceService.InvoiceCreated += auditLogger.LogInvoiceCreated;

invoiceService.InvoiceCreated += notificationService.NotifyInvoiceCreated;

Invoice invoice = invoiceService.CreateInvoice(
    id: 1001,
    customerName: "Ayman",
    amount: 15000
);

Console.WriteLine();

Console.WriteLine(
    $"Invoice returned: #{invoice.Id}"
);