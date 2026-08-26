Invoice invoice = new()
{
    Id = 10,
    Amount = 15_000,
    IsPaid = false,
    CustomerName = "Ayman"
};

Console.WriteLine("===== Invoice =====");

Console.WriteLine(
    $"Is Paid: {invoice.IsPaidInvoice()}"
);

Console.WriteLine(
    $"Is High Value: {invoice.IsHighValue()}"
);

Console.WriteLine(
    $"Is Valid: {invoice.IsValidInvoice()}"
);

Console.WriteLine(
    $"Summary: {invoice.GetSummary()}"
);

Console.WriteLine();

Console.WriteLine("===== Decimal =====");

decimal amount = 15_000;

Console.WriteLine(
    $"Is Large Amount: {amount.IsLargeAmount()}"
);

Console.WriteLine();

Console.WriteLine("===== String =====");

string customer = "Ayman";

Console.WriteLine(
    $"Is Valid Customer Name: {customer.IsValidCustomerName()}"
);