using InvoiceEventsLab.Models;

namespace InvoiceEventsLab.Events;

public delegate void InvoiceCreatedEventHandler(Invoice invoice);