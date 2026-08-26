namespace AccountingAsyncLab.Services;

public class FinancialReportService
{
    public async Task<decimal> GenerateReportAsync(
        CancellationToken cancellationToken)
    {
        Console.WriteLine();
        Console.WriteLine("Generating financial report...");

        for (int i = 1; i <= 10; i++)
        {
            cancellationToken.ThrowIfCancellationRequested();

            Console.WriteLine(
                $"Processing report section {i}/10...");

            await Task.Delay(
                500,
                cancellationToken);
        }

        Console.WriteLine(
            "Financial report completed.");

        return 100000m;
    }
}