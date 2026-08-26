namespace AccountingAsyncLab.Models;

public class DashboardResult
{
    public decimal TotalInvoices { get; set; }

    public decimal TotalPayments { get; set; }

    public decimal TotalExpenses { get; set; }

    public decimal TotalAccountsBalance { get; set; }
}