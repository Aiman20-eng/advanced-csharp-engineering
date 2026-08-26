namespace InvoiceEnumerableLab.Models;

public class Invoice
{
    public int Id { get; set; }

    public string CustomerName { get; set; } = string.Empty;

    public decimal Amount { get; set; }
}