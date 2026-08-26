using AccountingAsyncLab.Models;
using AccountingAsyncLab.Services;

InvoiceService invoiceService = new();

PaymentService paymentService = new();

ExpenseService expenseService = new();

DashboardService dashboardService = new(
    invoiceService,
    paymentService,
    expenseService);

FinancialReportService reportService = new();

Console.WriteLine("=================================");
Console.WriteLine("   ACCOUNTING ASYNC LAB");
Console.WriteLine("=================================");

using CancellationTokenSource dashboardCts = new();

try
{
    DashboardResult dashboard =
        await dashboardService.GetDashboardAsync(
            dashboardCts.Token);

    Console.WriteLine();
    Console.WriteLine("===== DASHBOARD RESULT =====");

    Console.WriteLine(
        $"Total Invoices: {dashboard.TotalInvoices:N2}");

    Console.WriteLine(
        $"Total Payments: {dashboard.TotalPayments:N2}");

    Console.WriteLine(
        $"Total Expenses: {dashboard.TotalExpenses:N2}");

    Console.WriteLine(
        $"Account Balance: {dashboard.TotalAccountsBalance:N2}");
}
catch (OperationCanceledException)
{
    Console.WriteLine(
        "Dashboard operation was cancelled.");
}

Console.WriteLine();
Console.WriteLine("=================================");
Console.WriteLine("   CANCELLATION DEMONSTRATION");
Console.WriteLine("=================================");

using CancellationTokenSource reportCts = new();

Task<decimal> reportTask =
    reportService.GenerateReportAsync(
        reportCts.Token);

await Task.Delay(2000);

Console.WriteLine();
Console.WriteLine("Requesting report cancellation...");

reportCts.Cancel();

try
{
    decimal reportTotal = await reportTask;

    Console.WriteLine(
        $"Report total: {reportTotal:N2}");
}
catch (OperationCanceledException)
{
    Console.WriteLine(
        "Financial report was cancelled successfully.");
}

Console.WriteLine();
Console.WriteLine("Application finished.");