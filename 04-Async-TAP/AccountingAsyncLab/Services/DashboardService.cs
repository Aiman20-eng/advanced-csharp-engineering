using AccountingAsyncLab.Models;

namespace AccountingAsyncLab.Services;

public class DashboardService
{
    private readonly InvoiceService _invoiceService;

    private readonly PaymentService _paymentService;

    private readonly ExpenseService _expenseService;

    public DashboardService(
        InvoiceService invoiceService,
        PaymentService paymentService,
        ExpenseService expenseService)
    {
        _invoiceService = invoiceService;
        _paymentService = paymentService;
        _expenseService = expenseService;
    }

    public async Task<DashboardResult> GetDashboardAsync(
        CancellationToken cancellationToken)
    {
        Console.WriteLine();
        Console.WriteLine("Loading accounting dashboard...");
        Console.WriteLine();

        Task<decimal> invoicesTask =
            _invoiceService.GetTotalInvoicesAsync(
                cancellationToken);

        Task<decimal> paymentsTask =
            _paymentService.GetTotalPaymentsAsync(
                cancellationToken);

        Task<decimal> expensesTask =
            _expenseService.GetTotalExpensesAsync(
                cancellationToken);

        await Task.WhenAll(
            invoicesTask,
            paymentsTask,
            expensesTask);

        DashboardResult result = new()
        {
            TotalInvoices = await invoicesTask,

            TotalPayments = await paymentsTask,

            TotalExpenses = await expensesTask,

            TotalAccountsBalance =
                await invoicesTask - await paymentsTask
        };

        return result;
    }
}