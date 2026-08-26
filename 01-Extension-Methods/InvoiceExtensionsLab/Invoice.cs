public class Invoice
{
    public int Id { get; set; }

    public decimal Amount { get; set; }

    public bool IsPaid { get; set; }

    public string CustomerName { get; set; } = string.Empty;
}