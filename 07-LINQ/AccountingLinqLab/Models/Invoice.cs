namespace AccountingLinqLab.Models;

public class Invoice
{
    public int Id { get; set; }

    public int CustomerId { get; set; }

    public decimal Amount { get; set; }

    public bool IsPaid { get; set; }

    public DateTime IssueDate { get; set; }
}