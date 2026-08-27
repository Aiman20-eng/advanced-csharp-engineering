using AccountingLinqLab.Data;
using AccountingLinqLab.Grouping;
using AccountingLinqLab.Joining;
using AccountingLinqLab.Transformation;

Console.WriteLine("==========================================");
Console.WriteLine("        ACCOUNTING LINQ LAB");
Console.WriteLine("==========================================");

Console.WriteLine();
Console.WriteLine("========== DATA TEST ==========");

foreach (var customer in AccountingData.Customers)
{
    Console.WriteLine(
        $"Customer #{customer.Id} | " +
        $"{customer.Name} | " +
        $"{customer.City}");

    foreach (var invoice in customer.Invoices)
    {
        Console.WriteLine(
            $"   Invoice #{invoice.Id} | " +
            $"Amount: {invoice.Amount:N2}");
    }
}

Console.WriteLine();

Console.WriteLine("========== 09 - GROUPING ==========");

GroupByExample.Run();

Console.WriteLine();

Console.WriteLine("========== 10 - JOINING ==========");

JoinExample.Run();

Console.WriteLine();

Console.WriteLine("========== 11 - SELECT MANY ==========");

SelectManyExample.Run();

Console.WriteLine();

Console.WriteLine("==========================================");
Console.WriteLine("          LINQ LAB COMPLETED");
Console.WriteLine("==========================================");