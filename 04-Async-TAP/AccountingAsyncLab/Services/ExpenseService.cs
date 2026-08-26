using AccountingAsyncLab.Models;

namespace AccountingAsyncLab.Services;

public class ExpenseService
{
    public async Task<decimal> GetTotalExpensesAsync(
        CancellationToken cancellationToken)
    {
        Console.WriteLine("Loading expenses...");

        await Task.Delay(800, cancellationToken);

        List<Expense> expenses =
        [
            new Expense
            {
                Id = 1,
                Description = "Office Rent",
                Amount = 5000
            },

            new Expense
            {
                Id = 2,
                Description = "Internet",
                Amount = 2000
            },

            new Expense
            {
                Id = 3,
                Description = "Electricity",
                Amount = 3000
            }
        ];

        decimal total = expenses.Sum(expense => expense.Amount);

        Console.WriteLine(
            $"Expenses loaded. Total = {total:N2}");

        return total;
    }
}