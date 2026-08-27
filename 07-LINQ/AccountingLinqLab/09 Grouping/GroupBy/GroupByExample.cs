using AccountingLinqLab.Data;

namespace AccountingLinqLab.Grouping;

public static class GroupByExample
{
    public static void Run()
    {
        var report = AccountingData.Invoices
            .GroupBy(invoice => invoice.CustomerId)
            .Select(group => new
            {
                CustomerId = group.Key,

                InvoiceCount = group.Count(),

                TotalAmount =
                    group.Sum(invoice => invoice.Amount),

                AverageAmount =
                    group.Average(invoice => invoice.Amount),

                MaximumAmount =
                    group.Max(invoice => invoice.Amount)
            });

        foreach (var item in report)
        {
            Console.WriteLine(
                $"Customer #{item.CustomerId} | " +
                $"Invoices: {item.InvoiceCount} | " +
                $"Total: {item.TotalAmount:N2} | " +
                $"Average: {item.AverageAmount:N2} | " +
                $"Max: {item.MaximumAmount:N2}");
        }
    }
}