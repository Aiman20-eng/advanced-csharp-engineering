public static class InvoiceExtensions 
{
	public static bool IsPaidInvoice(this Invoice invoice)
	{
		return invoice.IsPaid;
	}
	public static bool IsHighValue(this Invoice invoice)
	{
		return invoice.Amount >= 10_000;
	}
	public static string GetSummary(this Invoice invoice)
	{
		string paymentStatus = invoice.IsPaid ? "Yes" : "No";

		return $"Invoice #{invoice.Id} | " +
			   $"Customer: {invoice.CustomerName} | " +
			   $"Amount: {invoice.Amount} | " +
			   $"Paid: {paymentStatus}";
	}

	public static bool IsValidInvoice(this Invoice invoice)
	{
		return invoice.Id > 0
			&& invoice.Amount > 0
			&& !string.IsNullOrWhiteSpace(invoice.CustomerName);
	}

}
