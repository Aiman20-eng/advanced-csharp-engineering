using AccountingLinqLab.Data;

namespace AccountingLinqLab.Partitioning;

public static class ChunkExample
{
    public static void Run()
    {
        var batches = AccountingData.Invoices
            .Chunk(2);

        int batchNumber = 1;

        foreach (var batch in batches)
        {
            Console.WriteLine(
                $"Batch #{batchNumber}");

            foreach (var invoice in batch)
            {
                Console.WriteLine(
                    $"  Invoice #{invoice.Id} | " +
                    $"Amount: {invoice.Amount:N2}");
            }

            batchNumber++;

            Console.WriteLine();
        }
    }
}