using AccountingLinqLab.Data;

namespace AccountingLinqLab.Aggregation;

public static class MinExample
{
    public static void Run()
    {
        decimal minimumAmount =
            AccountingData.Invoices
                .Min(invoice => invoice.Amount);

        Console.WriteLine(
            $"Minimum invoice amount: {minimumAmount:N2}");
    }
}