using AccountingLinqLab.Data;

namespace AccountingLinqLab.Aggregation;

public static class SumExample
{
    public static void Run()
    {
        decimal totalAmount =
            AccountingData.Invoices
                .Sum(invoice => invoice.Amount);

        decimal outstandingAmount =
            AccountingData.Invoices
                .Where(invoice => !invoice.IsPaid)
                .Sum(invoice => invoice.Amount);

        Console.WriteLine(
            $"Total invoice amount: {totalAmount:N2}");

        Console.WriteLine(
            $"Outstanding amount: {outstandingAmount:N2}");
    }
}