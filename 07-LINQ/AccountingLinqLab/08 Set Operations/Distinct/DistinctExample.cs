using AccountingLinqLab.Data;

namespace AccountingLinqLab.SetOperations;

public static class AverageExample
{
	public static void Run()
	{
		decimal averageAmount =
			AccountingData.Invoices
				.Average(invoice => invoice.Amount);

		Console.WriteLine(
			$"Average invoice amount: {averageAmount:N2}");
	}
}