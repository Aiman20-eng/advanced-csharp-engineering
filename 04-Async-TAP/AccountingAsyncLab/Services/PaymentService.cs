using AccountingAsyncLab.Models;

namespace AccountingAsyncLab.Services;

public class PaymentService
{
    public async Task<decimal> GetTotalPaymentsAsync(
        CancellationToken cancellationToken)
    {
        Console.WriteLine("Loading payments...");

        await Task.Delay(1500, cancellationToken);

        List<Payment> payments =
        [
            new Payment
            {
                Id = 1,
                Amount = 15000,
                PaymentDate = DateTime.Now
            },

            new Payment
            {
                Id = 2,
                Amount = 10000,
                PaymentDate = DateTime.Now
            }
        ];

        decimal total = payments.Sum(payment => payment.Amount);

        Console.WriteLine(
            $"Payments loaded. Total = {total:N2}");

        return total;
    }
}