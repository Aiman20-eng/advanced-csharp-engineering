using AccountingLinqLab.Data;

namespace AccountingLinqLab.Aggregation;

public static class MaxExample
{
    public static void Run()
    {
        decimal maximumAmount =
            AccountingData.Invoices
                .Max(invoice => invoice.Amount);

        Console.WriteLine(
            $"Maximum invoice amount: {maximumAmount:N2}");
    }
}