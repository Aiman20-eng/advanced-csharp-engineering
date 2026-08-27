using AccountingLinqLab.Data;

namespace AccountingLinqLab.Joining;

public static class JoinExample
{
    public static void Run()
    {
        var report =
            AccountingData.Invoices
                .Where(invoice => !invoice.IsPaid)
                .Join(
                    AccountingData.Customers,

                    invoice => invoice.CustomerId,

                    customer => customer.Id,

                    (invoice, customer) => new
                    {
                        InvoiceId = invoice.Id,
                        CustomerName = customer.Name,
                        Amount = invoice.Amount
                    });

        Console.WriteLine(
            "=== Outstanding Invoice Report ===");

        foreach (var item in report)
        {
            Console.WriteLine(
                $"Invoice #{item.InvoiceId} | " +
                $"Customer: {item.CustomerName} | " +
                $"Amount: {item.Amount:N2}");
        }
    }
}